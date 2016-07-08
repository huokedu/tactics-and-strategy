﻿using Client.View;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Domain
{
    public sealed class WaterTextures
    {
        public TextureHolder CoastWithLandToTheNorth { get; private set; } = new TextureHolder();
        public TextureHolder CoastWithLandToTheSouth { get; private set; } = new TextureHolder();
        public TextureHolder Sea { get; private set; } = new TextureHolder();

        public WaterTextures()
        {
        }

        public WaterTextures(Texture2D terrain)
        {
            var spriteSize = new Point(32, 32);
            CoastWithLandToTheNorth = new TextureHolder(terrain, new Rectangle(new Point(10 * 32, 0 * 32), spriteSize));
            CoastWithLandToTheSouth = new TextureHolder(terrain, new Rectangle(new Point(4 * 32, 0 * 32), spriteSize));
            Sea = new TextureHolder(terrain, new Rectangle(new Point(2 * 32, 0 * 32), spriteSize));
        }
    }
}
