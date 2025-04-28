using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace P_1b
{
    public interface I1_Calculate
    {
        int area_of_rectangle(int x, int y);
    }

    public class Calculate_area_of_rectangle : I1_Calculate
    {
        public int area_of_rectangle(int x, int y)
        {
            return x * y;
        }
    }

}
