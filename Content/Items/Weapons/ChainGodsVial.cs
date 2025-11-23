using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod;
using System.Numerics;
using Terraria.DataStructures;
using RoleplayAddon.Content.Items.Other;
using RoleplayAddon.Content.Projectiles;


namespace RoleplayAddon.Content.Items.Weapons
{
    public class ChainGodsVial : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.ResearchUnlockCount = 1;
            Item.value = Item.sellPrice(gold: 10);
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.Turquoise>();

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.UseSound = SoundID.Item1;
            Item.noMelee = true;
            Item.noUseGraphic = true;

            Item.knockBack = 4f;
            Item.damage = 190;
            Item.crit = 8;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Melee;
        }
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ModContent.ItemType<ChainGodsVial>(), 1);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Chain, 10);
            recipe.AddIngredient(ItemID.LunarBar, 4);
            recipe.AddIngredient(ModContent.ItemType<Umbrafluid>(), 2);
            recipe.Register();
        }
        public override bool MeleePrefix()
        {
            return true;
        }
        public override bool AltFunctionUse(Player player) => true;

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Vector2 velocity, int type, int damage, float knockback)
        {
            if(player.altFunctionUse == 2)
            {
                //Placeholder
                //Katana Swing. Replace the "Type" variable with the projectile being used for each attack type
                Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<ChainGodsVialFlailProjectile>(), damage, knockback, Main.myPlayer);
                return false;
            }
            //Flail Throw
            Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<ChainGodsVialFlailProjectile>(), damage, knockback, Main.myPlayer);
            return false;
        }
    }
}