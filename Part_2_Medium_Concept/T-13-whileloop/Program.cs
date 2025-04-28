using System;


namespace T_13_whileloop
{
     class Program
    {
        static void Main()
        {
            int start = 0;
            Console.WriteLine("Enter the Target");
            int target = int.Parse(Console.ReadLine());
            while (start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
            
        }
    }
}
