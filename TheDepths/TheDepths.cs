using log4net.Repository.Hierarchy;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using TheDepths;
namespace TheDepths
{
	public class TheDepths : Mod
	{
        public override void Load()
        {
            if (!Main.dedServ)
            {
                //GameShaders.Misc["TheDepths:ChasmeDeath"] = new MiscShaderData(new Ref<Effect>((Effect)ModContent.Request<Effect>("TheDepths/Shaders/ChasmeDeathEffect", ReLogic.Content.AssetRequestMode.ImmediateLoad)), "ChasmeAnimation").UseImage0("Images/Misc/Perlin");
            }
        }
    }
}

