using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_1b;

namespace P_1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of L and B");
            int x=int.Parse(Console.ReadLine());    
            int y=int.Parse(Console.ReadLine());        
            Calculate_area_of_rectangle c1= new Calculate_area_of_rectangle();
            Calculate_area_of_triangle c2 = new Calculate_area_of_triangle();
            Console.WriteLine( c1.area_of_rectangle(x,y));
            Console.WriteLine(c2.area_of_triangle(5, 6));

        }
    }
}
