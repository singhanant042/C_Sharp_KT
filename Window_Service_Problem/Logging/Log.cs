using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace Logger
{
    public class Log
    {
        private readonly Timer timer;
        private string content;
        public Log()
        {
            timer = new Timer(3000);
            timer.Elapsed += TimerElasped;
        }

        private void TimerElasped(object sender, ElapsedEventArgs e)
        {
            
           
            if (!string.IsNullOrEmpty(content))
            {
                // Log the result only if there's something to log
                File.AppendAllText(@"C:\Users\sinanant\C_sharp\Window Service Problem\Client\log.txt", $"{DateTime.Now} - {content}{Environment.NewLine}");
            }
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public void SetResult(string result)
        {
            content = result;
        }
    }
}
