using System;
using System.Runtime.CompilerServices;




// Method hiding--> whenever we inheritance the property of base class,we also the method which are present in base
// 1. Now if we create method of the same name in derives class as present in base class,then method created in base will getr hide by methods in derives one
// 2. it will show some warning
// 3,.to avoid this just add "new" keyword after access modifier

public class Employee
{
     public string first_name;
    public string last_name;

    public void print()
    {
        Console.WriteLine(first_name +" " + last_name);
    }

}

public class Full_time:Employee
{
    //public  void print()
    //{
    //    Console.WriteLine(first_name + last_name + " FTE");
    //}

    // without using new it will show some warning
    // it u want to hide method intensionally use "new" keyword
    public new void print()
    {
        Console.WriteLine(first_name +" " + last_name + " FTE");
        //base.print();
        // by using above method we can prevent methods hiding
    }
}
namespace T_24_methodhiding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Full_time f1 = new Full_time();
            f1.first_name = "Anant";
            f1.last_name = "Singh";
            f1.print();

            //  another way  to avoid hiding of base clase method
            Employee f2 = new Full_time();
            f2.first_name = "Amit";
            f2.last_name = "Singh";
            f2.print(); ;

            // above is a another way to solve method hiding
            
        }
    }
}
