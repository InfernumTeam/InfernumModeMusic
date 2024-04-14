﻿using InfernumModeMusic.Projectiles;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.Items
{
    public class SoulDrivenHeadphones : ModItem
    {
        public override void SetStaticDefaults() => Item.ResearchUnlockCount = 1;

        public override void SetDefaults()
        {
            Item.width = 58;
            Item.height = 76;
            Item.useTime = Item.useAnimation = 4;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 0f;

            InfernumModeMusic.Infernum?.Call("RegisterAsSoulHeadphones", Item);

            Item.autoReuse = false;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<SoulDrivenHeadphonesProj>();
            Item.channel = true;
            Item.shootSpeed = 0f;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine line = tooltips.FirstOrDefault(x => x.Mod == "Terraria" && x.Name == "Tooltip1");
            TooltipLine line2 = tooltips.FirstOrDefault(x => x.Mod == "Terraria" && x.Name == "Tooltip2");

            if (line is not null && line2 is not null)
                line.OverrideColor = line2.OverrideColor = new((int)MathHelper.Lerp(156f, 255f, Main.DiscoR / 256f), 108, 251);
        }

        public override bool CanUseItem(Player player) => player.ownedProjectileCounts[Item.shoot] <= 0;

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.Stinger);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
