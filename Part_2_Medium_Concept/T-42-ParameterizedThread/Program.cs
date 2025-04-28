using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T_42_ParameterizedThread
{
      class Program
    {
         public  static void Main()
        {
            Program P = new Program();
            Thread t1 = new Thread(P.DisplayNumbers);
            t1.Start(10);

        }


       

        //can pass only object type in parameterized thread;
        public void DisplayNumbers(object Max) 
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }
}
