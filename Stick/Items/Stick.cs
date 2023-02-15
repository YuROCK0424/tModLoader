using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Stick.Items
{
	public class Stick : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stick"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Who are you going to kill with THIS?!");
		}

		public override void SetDefaults()
		{
			Item.damage = 2;
			Item.DamageType = DamageClass.Melee;
			Item.width = 16;
			Item.height = 16;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.value = 0;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}