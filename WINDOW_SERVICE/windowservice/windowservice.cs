using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace windowservice
{
    public class Run_service
    {
        private readonly Timer _timer;

        public Run_service()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerElasped;
        }

        private void TimerElasped(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\Users\sinanant\C_sharp\windowservice\log.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }
    }
}
