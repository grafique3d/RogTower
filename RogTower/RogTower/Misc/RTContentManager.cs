using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogTower.Misc
{
    public static class RTContentManager
    {
        public static Dictionary<string, Texture2D> Textures = new Dictionary<string, Texture2D>();

        public static void Load(ContentManager content)
        {
            Console.WriteLine("Loading content...");

            #region Load texture
            AddTexture("PlayerIdle0", content.Load<Texture2D>("Textures/Entity/Player/adventurer-idle-00"));
            #endregion

            Console.WriteLine("Content loaded !");
        }

        public static void AddTexture(string name, Texture2D texture)
        {
            Textures.Add(name, texture);
            Console.WriteLine("Texture loaded: " + name);
        }

        public static Texture2D GetTexture(string name)
        {
            return Textures[name];
        }

    }
}
