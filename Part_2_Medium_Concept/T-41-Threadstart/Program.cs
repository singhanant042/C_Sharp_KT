using System.Threading;
using System;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the ThreadStart Delegate instance by passing the
            //method name as a parameter to its constructor
            ThreadStart obj = new ThreadStart(DisplayNumbers);

            //Passing the ThreadStart Delegate instance as a parameter to its constructor
            Thread t1 = new Thread(obj);

            t1.Start();
            Console.Read();
        }

        static void DisplayNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
    }
}