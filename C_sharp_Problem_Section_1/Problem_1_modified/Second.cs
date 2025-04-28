using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_1b
{
    public interface I2_Calculate
    {
        double area_of_triangle(int x, int y);
    }

    public class Calculate_area_of_triangle : I2_Calculate
    {
        public double area_of_triangle(int x, int y)
        {
            return 0.5 * (double)x * (double)y;
        }

    }
}


