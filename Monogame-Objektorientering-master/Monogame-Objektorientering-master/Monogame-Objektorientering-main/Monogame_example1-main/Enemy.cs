using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Enemy : Sprite
{
    public Enemy(Texture2D newTexture, Vector2 newPosition) : base(newTexture, newPosition)
    {
    }

    public Enemy(Texture2D newTexture, Vector2 newPosition, Rectangle newBoundingBox) : base(newTexture, newPosition, newBoundingBox)
    {
    }

    public void Move(){
        if (Keyboard.GetState().IsKeyDown(Keys.Left))
        {
            Position.X -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.Right))
        {
            Position.X += Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.Up))
        {
            Position.Y -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.Down))
        {
            Position.Y += Speed;
        }
        BoundingBox = new Rectangle((int)Position.X, (int)Position.Y, 20, 20);
    }
    public void Draw(SpriteBatch sprite)
    {
        sprite.Draw(Texture, BoundingBox, Color.Red);
    }
}