using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RogTower.Misc;

namespace RogTower.GameObjects.Entities.Livings
{
    class Player : LivingEntity
    {
        public Player()
        {
            this.Size = new Vector2(100, 74);
            this.Position = new Vector2(50, 50);
        }

        public override Texture2D GetSprite()
        {
            return RTContentManager.GetTexture("PlayerIdle0");
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            base.Draw(spriteBatch, gameTime);
            Console.WriteLine(this.Sprite.Name);
        }
    }
}
