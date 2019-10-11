using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestTask
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static string Encode(string s, Encoder encoder)
        {
            // Preprocess stuff            

            string result = encoder.EncodeString(s);

            // Postprocess stuff

            return result
        }
    }
}
