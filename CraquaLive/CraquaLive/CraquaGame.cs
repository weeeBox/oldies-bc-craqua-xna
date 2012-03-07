using bc.flash.native;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using bc.core.device;
using bc.core.resources.loaders;
using bc.game;
using System.Diagnostics;
using bc.ui;
using bc.flash;

namespace CraquaLive
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class CraquaGame : Microsoft.Xna.Framework.Game
    {
        const int WIDTH = 640;
        const int HEIGHT = 480;

        GraphicsDeviceManager graphics;
        NativeApplication app;

        public CraquaGame()
        {
            graphics = new GraphicsDeviceManager(this);            
            graphics.PreferredBackBufferWidth = WIDTH;
            graphics.PreferredBackBufferHeight = HEIGHT;

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
#if WINDOWS
            IsMouseVisible = true;
#endif

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            app = new NativeApplication(WIDTH, HEIGHT, Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            base.Update(gameTime);

            if (app.isRunning())
            {
                AsGlobal.setTimer((int)gameTime.TotalGameTime.TotalMilliseconds);

                float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
                app.Tick(deltaTime);
            }
            else
            {
                Exit();
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            app.Draw(GraphicsDevice);

            base.Draw(gameTime);
        }
    }
}
