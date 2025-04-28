using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    public partial class windowhost : ServiceBase
    {
        ServiceHost host;
        public windowhost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(Service.Service1));
            host.Open();

        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
