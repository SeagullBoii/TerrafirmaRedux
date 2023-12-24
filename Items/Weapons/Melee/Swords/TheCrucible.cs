﻿using Microsoft.Xna.Framework;
using System;
using TerrafirmaRedux.Particles;
using TerrafirmaRedux.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrafirmaRedux.Items.Weapons.Melee.Swords
{
    public class TheCrucible : ModItem
    {
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void SetDefaults()
        {
            Item.DefaultToSword(65, 30,8);
            Item.shoot = ModContent.ProjectileType<CrucibleBeam>();
            Item.shootSpeed = 10;
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (player.ItemAnimationJustStarted)
            {
                SoundEngine.PlaySound(SoundID.Item20, player.position);
            }

            Utils.GetPointOnSwungItemPath(72, 72, 0.2f + 0.8f * Main.rand.NextFloat(), Item.scale, out var location2, out var outwardDirection2, player);
            Vector2 vector2 = outwardDirection2.RotatedBy((float)Math.PI / 2f * (float)player.direction * player.gravDir);
            ParticleSystem.AddParticle(new HiResFlame(), 
                player.Center + vector2.RotatedBy(player.direction * -MathHelper.PiOver2 * Main.rand.NextFloat(0.8f,1.2f)) * Main.rand.Next(24,90),
                new Vector2(player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f) + vector2 * Main.rand.NextFloat(2,5), 
                Utils.getAgnomalumFlameColor() * Main.rand.NextFloat(0.8f, 1f));
            if (Main.rand.NextBool(5))
            {
                ParticleSystem.AddParticle(new ColorDot(),
                    player.Center + vector2.RotatedBy(player.direction * -MathHelper.PiOver2 * Main.rand.NextFloat(0.8f, 1.2f)) * Main.rand.Next(24, 90),
                    new Vector2(player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f) + vector2 * Main.rand.NextFloat(2, 5),
                    Utils.getAgnomalumFlameColor() * Main.rand.NextFloat(0.8f, 1f), 0.2f);
            }
            //int num15 = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.GemDiamond, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 140, default(Color), 0.7f);
        }
    }
}
