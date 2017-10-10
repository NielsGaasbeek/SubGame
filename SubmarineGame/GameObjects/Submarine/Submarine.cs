using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGame
{
    class Submarine : GameObject
    {
        SubmarinePart[,] submarine;


        public Submarine() : base()
        {
            submarine = new SubmarinePart[4, 3];
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Draw()
        {
            foreach (SubmarinePart subPart in submarine)
                subPart.Draw();
        }
    }
}
