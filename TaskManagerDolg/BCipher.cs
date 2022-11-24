using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10
{
    internal class BCipher : ICipher
    {
        public string Encode(string t)
        {
            StringBuilder str = new StringBuilder();
            foreach (char c in t)
            {
                if (Char.IsUpper(c))
                {
                    str.Append((char)(65 + (90 - c)));
                }
                else
                {
                    str.Append((char)(97 + (122 - c)));
                }
            }
            return str.ToString();
        }
        public string Decode(string t)
        {
            StringBuilder str = new StringBuilder();
            foreach (char c in t)
            {
                if (Char.IsUpper(c))
                {
                    str.Append((char)(65 + (90 - c)));
                }
                else
                {
                    str.Append((char)(97 + (122 - c)));
                }
            }
            return str.ToString();
        }
    }
}
