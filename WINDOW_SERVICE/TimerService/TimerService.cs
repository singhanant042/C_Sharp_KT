using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerService
{
        public class SrvTimer
        {
            private Timer timer;

            private int counter = 0;

            public SrvTimer()
            {
                timer = new Timer(RunCounter, null, Timeout.Infinite, Timeout.Infinite);
            }

            private void RunCounter(Object obj)
            {
                counter++;
                String Entry = "Counter Val: [" + counter + "]" + Environment.NewLine + DateTime.Now.ToString();
                EventLog.WriteEntry("counter", Entry);

            }


            public void StartCounter()
            {
                timer.Change(1000, 5000);
            }

            public void StopCounter()
            {
                timer.Change(Timeout.Infinite, 5000);
            }
        }
    
}
