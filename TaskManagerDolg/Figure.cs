using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerDolg
{
    abstract class Figure
    {
        public string Colour { get; set; }
        public enum Status
        {
            Visivle, Invisible
        }
        public virtual void MoveX(int t) { }
        public virtual void MoveY(int t) { }
        public virtual void ChangeColour() { }
        public virtual void CheckStatus() { }
    }
}
