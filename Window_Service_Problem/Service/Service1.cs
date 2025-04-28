using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private int a;
        private int b;
        public int input_y(int y)
        {
            b = y;
            return b;
        }

        public int intput_x(int x)
        {
            a = x;
            return a;
        }

        public int  operation(int x, int y)
        {
            return x + y;
        }
    }
}
