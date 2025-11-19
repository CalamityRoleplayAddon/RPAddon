using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoleplayAddon.Content
{
    public class ChainGodsVial : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.value = Item.sellPrice(gold: 10);
            //Change to calamity turquoise rarity later
            Item.rare = ItemRarityID.Purple;

            //All of the usestyle/animation stuff rn is a placeholder
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.useStyle = ItemUseStyleID.Swing;

            Item.knockBack = 4;
            Item.damage = 190;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Melee;
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(this, 1);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Chain, 10);
            recipe.AddIngredient(RoleplayAddon, "Umbrafluid");
            recipe.Register();
        }

        public override bool MeleePrefix()
        {
            return true;
        }
    }
}