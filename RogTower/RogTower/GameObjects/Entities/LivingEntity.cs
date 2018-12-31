using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogTower.GameObjects.Entities
{
    public abstract class LivingEntity : Entity
    {
        public int Health { get; protected set; }

    }
}
