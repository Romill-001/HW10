using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10
{
    internal class ACipher : ICipher
    {

        public string Encode(string t)
        {
            StringBuilder str = new StringBuilder();
            foreach(char c in t)
            {
                str.Append((char)((int)c + 1));
            }
            return str.ToString();
        }
        public string Decode(string t)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char ch in t)
            {
                sb.Append((char)((int)ch - 1));
            }
            return sb.ToString();
        }
    }
}
