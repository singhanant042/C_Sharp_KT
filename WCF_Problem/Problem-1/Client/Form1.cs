using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
   
    public partial class Form1 : Form
    {

        Service.ServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new Service.ServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content= client.get_content(textBox1.Text);
            string path= client.get_path(textBox2.Text);
            label1.Text = "Writting";
            client.Write_file(path,content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = client.get_path(textBox2.Text);
            
            string data = client.Read_file(path);
            label1.Text = "Data " + data;
        }
    }
}
