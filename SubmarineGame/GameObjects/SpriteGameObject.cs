using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGame
{
    class SpriteGameObject : GameObject
    {
        string filePath;

        public SpriteGameObject(string path) : base()
        {
            filePath = path;
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
