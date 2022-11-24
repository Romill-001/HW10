using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov10;

namespace TaskManagerDolg
{
    class Rectangle : Point, IPloshyad
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
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
            Colour = "Yellow";
        }
        public new void Print()
        {
            Console.WriteLine(X + " " + Y + " " + Colour);
        }
        public void P()
        {
            Console.WriteLine("P is {0}", 2 * (Height + Width));
        }
    }
}
