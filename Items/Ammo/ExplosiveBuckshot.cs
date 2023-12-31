﻿using TerrafirmaRedux.Projectiles.Ranged;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TerrafirmaRedux.Items.Ammo
{
    internal class ExplosiveBuckshot : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 9;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 18;
            Item.height = 30;
            Item.maxStack = Item.CommonMaxStack;
            Item.consumable = true;
            Item.knockBack = 3f;
            Item.value = Item.sellPrice(0, 0, 0, 12);
            Item.rare = ItemRarityID.LightRed;
            Item.shoot = ModContent.ProjectileType<ExplosiveBuckshotProjectile>();
            Item.shootSpeed = 2f;
            Item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            CreateRecipe(50)
            .AddIngredient(ItemID.ExplodingBullet, 50)
            .AddIngredient(ModContent.ItemType<Buckshot>(), 50)
            .AddTile(TileID.MythrilAnvil)
            .Register();
        }

    }
}