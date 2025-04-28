using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class Calculate
{
    [Obsolete("Use  add(List<int> list) Method ")]
    public static int  add(int x,int y)
    {
        return x + y;
    }

    public  static int  add(List<int> list)
    {
        int sum = 0;
         foreach(int x in list)
        {
            sum += x;
        }
        return sum;
    }
}

namespace T_39_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(Calculate.add(10, 10));
        }
    }
}
