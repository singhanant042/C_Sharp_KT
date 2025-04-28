﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Console_host
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(Service.Service1)))
            {
                host.Open();
                Console.WriteLine("Hosting started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }

        }
    }
}
