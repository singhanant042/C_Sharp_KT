using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T_12b_switch
{
     class Program
    {
        static void Main()
        {
            int total_p = 0;
            Start:
            Console.WriteLine("1-2-3");
            int ans = int.Parse(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    total_p += 1;
                    break;
                case 2:
                    total_p += 2;
                    break;
                case 3:
                    total_p += 3;
                    break;
                default:
                    Console.WriteLine("Option is invalid");
                    break;
            }

            Console.WriteLine("Want to shop more:Yes OR No?");
            string ans_1 = Console.ReadLine();

            switch (ans_1)
            {
                case "Yes":
                    goto Start;
                case "No":
                    break;
            }
            Console.WriteLine("Thank you");
            Console.WriteLine("Bill-{0}", total_p);
        }
    }
}
