using System;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Xml.Serialization;
public class Employee
{
    public string f_name = "FN";
    public string l_name = "LN";

    //public void print()
    //{
    //    Console.WriteLine(f_name+" " + l_name);
    //}

    // here we can see that
    //1. here we are not able to print the name according to their class
    //2. to do that we can override the method which are present in base class by using virtual keyword and overide
    // vitual is used to override the methods in base class

    public virtual void print()
    {
        Console.WriteLine(f_name + " " + l_name);
    }
}

public class full_time : Employee
{

    // add keyword override after access modifier
    public override void print()
    {
        Console.WriteLine(f_name + " " + l_name + " FullTime");
    }
}

namespace T_25_Polymorhpism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            full_time f1 = new full_time();
            f1.print();
        }
    }
}
