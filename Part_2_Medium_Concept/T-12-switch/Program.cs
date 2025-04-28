using System;


namespace T_12_switch
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 10:
                    Console.WriteLine("Num is 10");
                    break;
                case 20:
                    Console.WriteLine("Num is 20");
                    break;
                case 30:
                    Console.WriteLine("Num is 30");
                    break;
                default:
                    Console.WriteLine("Belong to none");
                    break;
            }

        }
    }
}
