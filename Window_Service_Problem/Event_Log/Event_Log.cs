using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;

namespace Event_Logging
{
    public class Event_Log
    {
        private Timer timer;
        private EventLog eventlog;
        private string content;
        public Event_Log()
        {
            timer = new Timer(2000);
            timer.Elapsed += Event_Elasped;


            eventlog = new EventLog();

            if(!EventLog.SourceExists("MyAppLogger"))
            {
                EventLog.CreateEventSource("MyAppLogger", "Application");
            }

            eventlog.Source = "MyAppLogger";
            eventlog.Log = "Application";
        }

        private void Event_Elasped(object sender, ElapsedEventArgs e)
        {
            if(!string.IsNullOrEmpty(content)) {
                eventlog.WriteEntry($"{DateTime.Now}--{content}", EventLogEntryType.Information);            }
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
