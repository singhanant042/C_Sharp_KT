using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;

namespace Log4net_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log=log4net.LogManager.GetLogger(typeof(Program));

            try
            {
                Console.WriteLine("Enter the value");
                int x = int.Parse(Console.ReadLine()):
                int y = int.Parse(Console.ReadLine());

                int result = x / y;

                log.Info("Result={0}", result);
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }


        }
    }
}
