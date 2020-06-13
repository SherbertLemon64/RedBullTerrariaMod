using Terraria.ID;
using Terraria.ModLoader;

namespace RedBull.Items
{
	public class RedBull : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("RedBull"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("red bull gives you wiiinnggs");
		}

		public override void SetDefaults() 
		{
			item.maxStack = 30;
			item.width = 40;
			item.height = 68;
			item.rare = 4;
			Items.value = 5000;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}