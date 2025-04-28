using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T_18_methodparameters
{
  class Program
    {
       public  static void Main(string[] args)
        {
            int j = 0;
            Program.print( ref j);
            // to pass the parameter by refernce ,u have to write "ref" before the variable while passing parameters
            Console.WriteLine(j);

            int sum = 0;
            int pro = 0;

           // Program.solve(10, 10, out sum, out pro);
           // Console.WriteLine("sum= {0} & Product= {1}", sum, pro);
            solve(10, 20, ref sum, out pro);
            Console.WriteLine("sum= {0} & Product= {1}", sum, pro);


            // trying out params methods
            int[] array = new int[5];
            for(int i = 0; i < 5; i++)
            {
                int val = int.Parse(Console.ReadLine());
                array[i] = val;
            }
            Console.WriteLine("start from here");
            paramsmethod(array);
        }
        public static void  print( ref int i)
        {
            i = 100;
        }


        // out parameter--> used when u want to return more than one output


        public static void solve(int a,int b,ref int sum,out int pro)
        {
            sum = a + b;
            pro = a * b;
        }


        // params
        public static void paramsmethod( int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
