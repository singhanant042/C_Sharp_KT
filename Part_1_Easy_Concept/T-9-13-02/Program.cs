using System;


namespace T_9_13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 1333.34F;
            // cannot implicitly convert float to int
            //Fractional part will be lost
            // float is bigger datafloat so there is also possibility of overflow exception
            //Have to use explicit conversion using cast () operator 
            //int i = (int)f;

            // or use convert class
            int i = Convert.ToInt32(f);
            Console.WriteLine(i);
        }
    }
}
