using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSfortesting
{
    public partial class TestingWS : ServiceBase
    {
        public TestingWS()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Starting the test service");
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Stopping the test serice");
        }
    }
}
