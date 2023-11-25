using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Queue_Customer_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Customer c;
        Queue q = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            c = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            q.Enqueue(c);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-----Before Dequeue---------"+"\n");
            foreach(Customer c in q)
            {
                sb.Append("ID : " + c.CustomerID + "\n" + "Name : " + c.Name + "\n" + "Email : " + c.Email + "\n" + "Mobile No : " + c.MobileNo + "\n");
            }
            label5.Text = sb.ToString();

            q.Dequeue();
            sb.Append("-----After Dequeue---------"+"\n");
            foreach (Customer c in q)
            {
                sb.Append("ID : " + c.CustomerID + "\n" + "Name : " + c.Name + "\n" + "Email : " + c.Email + "\n" + "Mobile No : " + c.MobileNo + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
