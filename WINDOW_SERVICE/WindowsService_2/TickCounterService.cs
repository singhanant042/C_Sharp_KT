using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using TimerService;

namespace WindowsService_2
{
    public partial class TickCounterService : ServiceBase
    {

        private SrvTimer TimerEv;
        public TickCounterService()
        {
            InitializeComponent();

            TimerEv = new SrvTimer();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Tick Counter Started");


            TimerEv.StartCounter();
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Tick Counter Stopped");
            TimerEv.StopCounter();
        }
    }
}
