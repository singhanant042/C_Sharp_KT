using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;



namespace HelloServiceHost
{
    internal class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true,
                };

                host.Description.Behaviors.Add(serviceMetadataBehavior);
                host.AddServiceEndpoint(typeof(HelloService.IHelloService), new NetTcpBinding(), "HelloService");
                //host.AddServiceEndpoint(typeof(HelloService.IHelloService), new BasicHttpBinding , "HelloService");


                host.Open();
                Console.WriteLine("Host started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }

        }
    }
}
