using System;
using System.Linq.Expressions;

interface I1
{
    void print();
}
interface I2
{
    void print();
}

//public class Class:I1,I2
//{
//    //public void print()
//    //{
//    //    Console.WriteLine("Interface 1");
//    //}

//    void I1.print()
//    {
//        Console.WriteLine("Interface 1");
//    }

//    void I2.print()
//    {
//        Console.WriteLine("Interface 2");
//    }

    
//}

// here we can see that both interface have same method,so this will create confusion that which method will invoke after in by the object
// how we going to utilize both method in interfaces
// to solve this we explicitinterface
// in this we do not use access modifier
namespace T_32_ExplicitInterface
{
    internal class Program:I1,I2
    {
        void I1.print()
        {
            Console.WriteLine("I1 interface");
        }



        void I2.print()
        {
            Console.WriteLine("I2 interface");
        }
        static void Main(string[] args)
        {
            //Class C1 = new Class();
            Program p = new Program();
            //((I1)C1).print();
            //((I2)C1).print();
            ((I1)p).print();
            ((I2)p).print();

        }
    }
}
