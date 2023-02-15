using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Obsidian_Pickaxe.Items
{
	public class Obsidian_Pickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Obsidian_Pickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Able to mine Hellstone");
		}

		public override void SetDefaults()
		{
			Item.damage = 12;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.pick = 75;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 20000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
        {
			int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].noGravity = true;
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Ebonwood, 4);
			recipe.AddIngredient(ItemID.Obsidian, 12);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}