using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Customer
{

    // abstract may and may noy contain abstract member
    public abstract void print();
    public void print2()
    {
        Console.WriteLine("Abstract class");
    }
}
namespace T_33Abstract
{
    internal class Program:Customer
    {
        public  override void print()
        {
            Console.WriteLine("Hellow");
        }
        static void Main(string[] args)
        {
        //    Program p = new Program();
        //    p.print();


            Customer c1 = new Program();
            c1.print();
            c1.print2();
        }
    }
}
