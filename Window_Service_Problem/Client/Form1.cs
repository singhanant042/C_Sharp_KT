using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Logger;
using Event_Logging;


namespace Client
{
    public partial class Form1 : Form
    {
        Service.Service1Client client;
        private Log logger;
        private Event_Log event_log;
        //private Timer logTimer;
        public Form1()
        {
            InitializeComponent();
            client = new Service.Service1Client();
            logger = new Log();
            event_log = new Event_Log();

            //logTimer = new Timer();
            //logTimer.Interval = 30000; // 30,000 ms = 30 second
            //logTimer.Start();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int x = client.input_y(int.Parse(textBox1.Text));
                int y = client.intput_x(int.Parse(textBox2.Text));
                int result = client.operation(x, y);
                label1.Text =  result.ToString();
                // logger.Start();

                event_log.Start();


                //logger.SetResult($"Operation result: {result} , Date:{DateTime.Now.ToString()}");
               // logger.SetResult($"Operation result: {result} , Date:{DateTime.Now.ToString()}");
                event_log.SetResult($"Operation result: {result }");
            }


            catch (Exception ex)
            {

                //Logger.LogError("Exception during WCF call.", ex);
               
                //MessageBox.Show("Error occurred. See log for details.");


                label1.Text = $"Error: {ex.Message}";
                //logger.SetResult($"Error: {ex.Message}");
                event_log.SetResult($"Error: {ex.Message}");


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // logger.Stop();
            event_log.Stop();
        }
    }
}