﻿using Client.Domain;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.UWP
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // temporar variables to keep sample textures for demo purposes.
        private Texture2D unitsSprite;
        private Texture2D backgroundSprite;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            unitsSprite = Content.Load<Texture2D>(@"DesertRatsSprites");
            backgroundSprite = Content.Load<Texture2D>(@"Background");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            // get screen center
            var x = graphics.GraphicsDevice.Viewport.Width / 2;
            var y = graphics.GraphicsDevice.Viewport.Height / 2;

            // display sample island
            {
                var spriteSize = new Rectangle(1, 1 + 1 + 32, 32, 32);
                var island = new IslandEntity
                {
                    Corners = new[] { new GeoPoint(0, 0), new GeoPoint(2, 0), new GeoPoint(2, 2), new GeoPoint(0, 2) }
                };
                var points = new[] { island }.GeneratePoints();
                foreach (var point in points)
                {
                    spriteBatch.Draw(backgroundSprite, new Vector2(x + point.X * 32, y + point.Y * 32), spriteSize, Color.White);
                }
            }
            // display sample tank
            {
                var spriteSize = new Rectangle(1 + 1 + 32, 1, 32, 32);
                spriteBatch.Draw(unitsSprite, new Vector2(x, y), spriteSize, Color.White);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
