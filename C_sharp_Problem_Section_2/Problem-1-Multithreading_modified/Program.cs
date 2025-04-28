using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_1_Multithreading
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the values");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Operation o = new Operation(x,y);
            Thread t1 = new Thread(o.add);
            Thread t2 = new Thread(o.sub);
            Thread t3 = new Thread(o.multiply);
            Thread t4 = new Thread(o.Div);


            StreamWriter str = new StreamWriter(@"C:\Users\sinanant\C#\Sheet Problem\Problem-1-Multithreading\log.txt");
            str.Write("Addtion");
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }
    }

    public class Operation
    {
        int x;
        int y;

        public Operation(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void  add()
        {
            Console.WriteLine("Add = {0}", x + y) ;
        }

        public void  sub()
        {
            Console.WriteLine("Sub={0}", x - y);
        }
        public void multiply()
        {
            Console.WriteLine("Multiply={0}",x*y);
        }

        public void  Div()
        {
            Console.WriteLine("Divisio={0}", (double)x / (double)y);
        }
    }
}
