using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace windowservice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {

                x.Service<Run_service>(s =>
                {
                    s.ConstructUsing(run_service => new Run_service());
                    s.WhenStarted(run_service => run_service.Start());
                    s.WhenStopped(run_service => run_service.Stop());

                });

                x.SetServiceName("TestService");
                x.SetDisplayName("Test Service");
                x.SetDescription("This is just a test service for learning purpose");


            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;



            /*
             Environment.ExitCode is a property that sets or gets the exit code of the current process.
              The exit code is a numeric value that indicates the status or result of the process after it has finished executing.
              Exit Code = 0: A value of 0 typically means the process completed successfully(i.e., no errors occurred).

              Exit Code != 0: Any non-zero value typically indicates that an error or some issue occurred during the execution of the process.

             */



        }

    }
}
