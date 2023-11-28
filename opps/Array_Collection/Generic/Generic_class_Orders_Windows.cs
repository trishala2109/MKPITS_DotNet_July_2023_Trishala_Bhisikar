using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_class_Orders_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Orders O = null;
        static Dictionary<int, Orders> OrderCollection = new Dictionary<int, Orders>();
        private void button1_Click(object sender, EventArgs e)
        {
            Orders O = new Orders(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            OrderCollection.Add(O.OrderNo, O);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,Orders> kv in OrderCollection)
            {
                sb.Append("Order No. : " + kv.Key + "\n" + "Item : " + kv.Value.ItemName + "\n" + "Rate : " + kv.Value.Rate + "\n" + "Quantity : " + kv.Value.Quantity + "\n");
                sb.Append("----------------" + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
