using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10
{
    internal interface ICipher
    {
        string Encode(string t);
        string Decode(string t);
    }
}
