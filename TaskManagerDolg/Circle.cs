using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov10;

namespace TaskManagerDolg
{

    class Circle : Point, IPloshyad
    {
        public Circle(int r) { R = r; }
        public int R { get; set; }

        public override void MoveX(int t)
        {
            X += t;
        }
        public override void MoveY(int t)
        {
            Y += t;
        }
        public override void ChangeColour()
        {
            Colour = "Red";
        }
        public new void Print()
        {
            Console.WriteLine(X + " " + Y + " " + Colour);
        }
        public void P()
        {
            Console.WriteLine("P is {0}", Math.Round(2 * Math.PI * R));
        }
    }
}
