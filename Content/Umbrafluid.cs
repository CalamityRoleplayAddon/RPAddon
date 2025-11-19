using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoleplayAddon.Content
{
    public class Umbrafluid : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(gold: 5);
        }
        public override void AddRecipes()
        {
            //Add calamity mats later
            Recipe recipe = Recipe.Create(this, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}