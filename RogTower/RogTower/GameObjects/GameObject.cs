using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogTower.GameObjects
{
    public abstract class GameObject
    {
        public Vector2 Position { get; protected set; }
        public Vector2 Size { get; protected set; }
        public Texture2D Sprite { get; protected set; }
        public float Rotation { get; protected set; }
        public float Layer { get; protected set; }
        public SpriteEffects spriteEffect;

        private Color color;

        public Point Center
        {
            get
            {
                return new Point((int)this.Size.X/2, (int)this.Size.Y/2);
            }
        }

        public GameObject()
        {
            this.Position = Vector2.Zero;
            this.Size = Vector2.Zero;
            this.color = Color.White;

            this.Sprite = this.GetSprite();
        }

        public abstract Texture2D GetSprite();

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(this.Sprite, new Rectangle(this.Position.ToPoint(), this.Size.ToPoint()), new Rectangle(0, 0, this.Sprite.Width, this.Sprite.Height), this.color);
        }

    }
}
