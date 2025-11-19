using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoleplayAddon.Content
{
    public class ChainGodsVial : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Melee;
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(this, 1);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Chain, 10);
            recipe.AddIngredient(RoleplayAddon, "Umbrafluid");
            recipe.AddTile(TileID.LunarCraftingStation);
        }
    }
}