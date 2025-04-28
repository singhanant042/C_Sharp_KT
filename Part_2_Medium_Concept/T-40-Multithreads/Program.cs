using System;
using System.Threading;

namespace T_40_Multithreads
{
    class Program
    {

        static void Main(string[] args)
        {

            Thread t1 = new Thread(Print);
            t1.Start();


        }

        public static void Print()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
    
}
