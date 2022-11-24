using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov10;

namespace TaskManagerDolg
{
    class Point : Figure, IPrint
    {
        public int X { get; set; }
        public int Y { get; set; }
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
            Colour = "Green";
        }
        public void Print()
        {
            Console.WriteLine(X + " " + Y + " " + Colour);
        }
    }
}
