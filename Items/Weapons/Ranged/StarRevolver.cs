﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrafirmaRedux.Items.Weapons.Ranged
{
    internal class StarRevolver : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 32;
            Item.knockBack = 2f;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 16;
            Item.useTime = 16;
            Item.width = 38;
            Item.height = 26;
            Item.UseSound = SoundID.Item9;
            Item.DamageType = DamageClass.Ranged;
            Item.autoReuse = false;
            Item.noMelee = true;

            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(0, 0, 20, 0);

            Item.useAmmo = AmmoID.FallenStar;
            Item.shoot = ProjectileID.FallingStar;
            Item.shootSpeed = 16f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1,0);
        }
    }
}