using System;


namespace T_8_13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = i;
            Console.WriteLine(f);
            // float is bigger datatype  than int
            //data and Exception ,hence implicit conversion
            // implicit conversion done by compiler as flost is larger than int,no data loss
        }
    }
}
