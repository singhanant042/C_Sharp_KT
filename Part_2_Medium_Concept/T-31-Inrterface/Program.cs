using System;

 public interface ICustomer
{
    void print();
    void print(string s);
}

 public interface I2
{
    void print2();
}
public class Customer:ICustomer,I2
{
    public void print()
    {
        Console.WriteLine("Interface print method");
    }
    public void print(string name)
    {
        Console.WriteLine(name);
    }
    public  void print2()
    {
        Console.WriteLine("I2 interface");
    }
}

// NOTE=====> two interface I1 and I2,now if I2 inteherits from I1 ,and also a class C1 inhertis from I2,then methos present in both interfsces have to be initilize in class


namespace T_31_Inrterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.print();
            c1.print("Anant Singh");
            c1.print2();
        }
    }
}
