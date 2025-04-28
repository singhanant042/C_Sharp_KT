using System;
using System.Collections.Generic;


namespace T_10_13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;


            Console.WriteLine(arr[0]);

            //Note= Console.ReadLine() return string,so if need any other datatype then string we have to convert it explicitly
            // int.parse(Console.ReadLine())
           
        }
    }
}
