using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogTower.GameObjects
{
    public abstract class PhysicObject : GameObject
    {
        public Rectangle HitBox
        {
            get
            {
                return new Rectangle(this.Position.ToPoint(), this.Size.ToPoint());
            }
        }

        public virtual void Update()
        {
            CheckCollision();
        }

        public void CheckCollision()
        {
            //TODO: CHECKING COLLISION
        }

    }
}
