using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T_17_methods
{
    class Program
    {
        public static void Main()
        {
            //Program p = new Program();

            // if we not using static in our methods then we have to create a instance where we can store out method
            // if we use static then out created method stores in program no need to create instance

            //p.Even();

            Program.Even();
            Program.Even();
            int s = sum(4, 5);
            Console.WriteLine("Total sum={0}",s);
        }

        // creating our own methods  based on out requirements
        // syntax ====> access modifier return type method name(parameter)
    
        // method returning nothing
        public static  void Even()
        {
            for(int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
       
            }
        }
        //parametric methods
        public static int sum(int a,int b)
        {
            return a + b;
        }
    }
}
