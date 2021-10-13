using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Sprite{

    public Texture2D Texture{ get; set; }
    public Vector2 Position;
    public Rectangle BoundingBox{ get; set; }

    public Sprite(Texture2D newTexture, Vector2 newPosition, Rectangle newBoundingBox)
    {
        Texture = newTexture;
        Position = newPosition;
        BoundingBox = newBoundingBox;
    }

    public Sprite()
    { 
    }

    public float Speed = 2f;

    public void Move(){
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            Position.X -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            Position.X += Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            Position.Y -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            Position.Y += Speed;
        }
    }
    
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(Texture, Position, Color.White);
    }
}