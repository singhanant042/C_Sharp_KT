using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_28_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(2, 3);
            add(2, 3, 4);

        }

        public static void add(int a,int b)
        {
            Console.WriteLine("Sum ={0}", a + b);
        }

        public static void add(int a,int b,int c)
        {
            Console.WriteLine("Sum2={0}", a + b + c);
        }
    }
}
