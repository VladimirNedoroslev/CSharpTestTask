using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestTask
{
    class OffsetEncoder : Encoder
    {

        public override string EncodeString(string str)
        {
            string result = "";
            foreach (char ch in str)
            {
                char s = ch;
                s++;
                result += s;
            }
            return result;
        }
    }
}
