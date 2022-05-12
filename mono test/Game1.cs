using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace mono_test
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D adamTexture;
        Texture2D kevinTexture;
        Texture2D davidTexture;
        Texture2D chrisTexture;
        Texture2D robTexture;
        Texture2D grownTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Gabbagoo";
            _graphics.PreferredBackBufferWidth = 889;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            adamTexture = Content.Load<Texture2D>("adam");
            kevinTexture = Content.Load<Texture2D>("kevin");
            davidTexture = Content.Load<Texture2D>("david");
            robTexture = Content.Load<Texture2D>("rob");
            chrisTexture = Content.Load<Texture2D>("chris");
            grownTexture = Content.Load<Texture2D>("grown");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSeaGreen);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(grownTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(adamTexture, new Vector2(200, 20), Color.White);
            _spriteBatch.Draw(davidTexture, new Vector2(300, 20), Color.White);
            _spriteBatch.Draw(chrisTexture, new Vector2(400, 20), Color.White);
            _spriteBatch.Draw(robTexture, new Vector2(500, 20), Color.White);
            _spriteBatch.Draw(kevinTexture, new Vector2(600, 20), Color.White);

            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
