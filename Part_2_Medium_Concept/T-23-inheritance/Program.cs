using System;

public class Employee
{
     public string First_name;
     public string Last_name;
     public string Email;


      public Employee()
    {
        Console.WriteLine("First Cons");
    }

    public Employee( string msg)
    {
        Console.WriteLine("Second Cons" +" -> "+ msg);
    }

    public Employee(int a,int b)
    {
        Console.WriteLine("sum={0}",a+b);
    }
    public void print_name()
    {
        Console.WriteLine(this.First_name +" "+this.Last_name);
    }
}

public class Fulltime : Employee
{
    public float full_Salary;
    public Fulltime():base("Message")
    {
        Console.WriteLine("Chlid Construtor");
    }

}

public class Part_time:Employee
{
     public float part_Salary;
}
   
namespace T_33_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fulltime f1 = new Fulltime();
            f1.First_name = "Anant";
            f1.Last_name = "Singh";
            f1.Email = "singh@gmail.com";
            f1.print_name();
        }
    }
}
