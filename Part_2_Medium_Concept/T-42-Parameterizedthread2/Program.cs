using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace T_42_Parameterizedthread2
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            Number n = new Number(target);
            Thread t1 = new Thread(n.print);
            t1.Start();

        }
    }
}

public class Number
{
    int target;
    public Number(int target)
    {
        this.target = target;
    }

    public void print()
    {
        for(int i = 0; i < this.target; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}
