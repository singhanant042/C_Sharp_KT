using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClient.DBService;

namespace DBClient
{
    public partial class Form1 : Form
    {
        DBService.DBServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new DBService.DBServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertUser u = new InsertUser();
            u.ID = int.Parse(textBox5.Text);
            u.UserName = textBox4.Text;
            u.Password = textBox3.Text;
            u.Country = textBox2.Text;
            u.Email = textBox1.Text;

            string msg = client.Insert(u);

            label1.Text = msg.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateUser u = new UpdateUser();
            u.ID= int.Parse(textBox5.Text);
            u.Username = textBox4.Text;
            u.Password = textBox3.Text;
            u.Country = textBox2.Text;
            u.Email = textBox1.Text;

            string msg = client.Update(u);
            label1.Text = msg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUser d = new DeleteUser();
            d.ID=int.Parse(textBox5.Text);

            string msg = client.Delete(d);
            label1.Text = msg.ToString();
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    DBService.gettestdata g = new  DBService.gettestdata();
        //    g = client.GetInfo();
        //    DataTable dt = new DataTable();
        //    dt = g.employee_table;
        //    dataGridView1.DataSource = dt;
            

            
        //}
    }
}
