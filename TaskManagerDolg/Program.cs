using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerDolg;

namespace Tumakov10
{
    interface IPloshyad
    {
        void P();
    }
    interface IPrint
    {
        void Print();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ACipher a = new ACipher();
            string str = "Hello";
            Console.WriteLine(a.Encode(str));
            Console.WriteLine(a.Decode(a.Encode(str)));
            string t = "Hello World";
            BCipher b = new BCipher();
            Console.WriteLine(b.Encode(t));
            Console.WriteLine(b.Decode(b.Encode(t)));

            Point p = new Point();
            p.MoveX(10);
            p.MoveY(10);
            p.ChangeColour();
            p.Print();

            Circle c = new Circle(5);
            c.MoveX(10);
            c.MoveY(10);
            c.ChangeColour();
            c.P();
            c.Print();

            Rectangle r = new Rectangle(5, 10);
            r.MoveX(10);
            r.MoveY(10);
            r.ChangeColour();
            r.P();
            r.Print();

        }
    }
}
