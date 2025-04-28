using System;

namespace T_11_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number?");
            int num = int.Parse(Console.ReadLine());
            if(num > 10)
            {
                Console.WriteLine("Allowed");
            }
            else if (num == 10)
            {
                Console.WriteLine("Not Allowed");
            }
            else
            {
                Console.WriteLine("Try Later");
            }
        }
    }
}
