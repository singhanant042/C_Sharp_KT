using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T_5_13_02
{
   class Program
    {
        static void Main()
        {
            string name = "Anant Singh";
            //Take a look at Escape Seq of C sharp
            Console.WriteLine(name);
            string n="one\nTwo";
            Console.WriteLine(n);

            //  NOTE--if we put "@" before the string then all ecp seq used will be treated as printable character
            // this term is called Verbartim Literal

            string n_1 = @"one\nTwo";
            Console.WriteLine(n_1);
        }
    }
}
;
