using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogTower.GameObjects.Entities
{
    public abstract class Entity : PhysicObject
    {
        public Vector2 Velocity { get; protected set; }
        public float Speed { get; protected set; }

        public int Damage { get; protected set; }

        public Entity()
        {

        }
    }
}
