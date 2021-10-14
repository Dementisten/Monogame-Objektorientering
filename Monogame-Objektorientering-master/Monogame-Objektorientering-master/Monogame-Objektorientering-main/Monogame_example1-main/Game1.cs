using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameSprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Sprite player;
        Enemy enemy;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            //player = new Sprite(Content.Load<Texture2D>("box"), new Vector2(150,250), new Rectangle(150, 250, 200, 200));
            player = new Sprite(Content.Load<Texture2D>("box"), new Vector2(100, 100));
            player.BoundingBox = new Rectangle((int)player.Position.X, (int)player.Position.Y, 20, 20);

            enemy = new Enemy(Content.Load<Texture2D>("box"), new Vector2(500, 100));
            enemy.BoundingBox = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, 20, 20);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                    Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Move();
            enemy.Move();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            player.Draw(_spriteBatch);
            enemy.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
