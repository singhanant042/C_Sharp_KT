using System;

interface IA
{
    void Amethod();
}
class A:IA

{
    public void Amethod()
    {
        Console.WriteLine("A");
    }
}

interface IB
{
    void Bmethod();
    
}
class B:IB
{
    public void Bmethod()
    {
        Console.WriteLine("B");
    }
}
class AB : IA, IB
{
    A a = new A();
    B b = new B();
    B b = new B();
    public void Amethod()
    {
        a.Amethod();
    }

    public void Bmethod()
    {
        b.Bmethod();
    }
}
namespace T_33_MultipleInheritanceusingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.Amethod();
            ab.Bmethod();
        }
    }
}
