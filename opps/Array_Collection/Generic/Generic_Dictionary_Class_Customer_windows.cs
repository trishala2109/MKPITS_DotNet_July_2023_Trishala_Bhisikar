using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Dictionary_Class_Customer_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Dictionary<int, Customer> li = new Dictionary<int, Customer>();
        Customer c = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            li.Add(cust.ID,cust);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair <int, Customer> kv in li)
            {
                sb.Append("Customer ID : " + kv.Key + "\n" + "Name : "+ kv.Value.Name + "\n");
                sb.Append("--------------" + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
