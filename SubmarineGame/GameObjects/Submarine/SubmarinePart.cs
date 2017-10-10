using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGame
{
    abstract class SubmarinePart : SpriteGameObject
    {
        Vector2 gridPos;

        public SubmarinePart(string path, Vector2 gridPos) : base(path)
        {
            this.gridPos = gridPos;
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
