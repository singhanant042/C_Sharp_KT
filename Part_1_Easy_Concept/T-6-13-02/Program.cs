using System;


namespace T_6_13_02
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 110, b = 20;
            if(a==b || a > b)
            {
                Console.WriteLine("Hellow");
            }

            int c = 10, d = 20;
            string ans = c == d ? "equal" : "not equal";
            Console.WriteLine(ans);
        }
    }
}
