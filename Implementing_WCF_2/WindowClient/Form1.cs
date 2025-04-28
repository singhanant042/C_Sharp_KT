using System;
using System.ServiceModel;
using System.Windows.Forms;



namespace WindowClient
{
    public partial class Form1 : Form
    {

        HelloService.HelloServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HelloService.HelloServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if(client.State == CommunicationState.Faulted)
                {
                    client = new HelloService.HelloServiceClient();
                }
                label1.Text = client.GetMessage(textBox1.Text);

            }

            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
            
        }
    }
}
