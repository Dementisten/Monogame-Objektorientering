﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogameSprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Player player;
        Enemy enemy;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            player = new Player(Content.Load<Texture2D>("box"), 
            new Vector2(100, 100));
            player.BoundingBox = new Rectangle((int)player.Position.X, (int)player.Position.Y, 30, 30);

            enemy = new Enemy(Content.Load<Texture2D>("box"), 
            new Vector2(500, 100));
            enemy.BoundingBox = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, 30, 30);


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