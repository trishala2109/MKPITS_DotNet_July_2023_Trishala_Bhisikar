using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Orders_Total_Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Order_Bill O = null;
        static Dictionary<int, Order_Bill> OrderCollection = new Dictionary<int, Order_Bill>();
        private void button1_Click(object sender, EventArgs e)
        {
            Order_Bill O = new Order_Bill(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            OrderCollection.Add(O.ID, O);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            MessageBox.Show("customer objects added to dictionary colletion");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int Total = 0;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, Order_Bill> kv in OrderCollection)
            {
                int Amount = kv.Value.Rate * kv.Value.Quantity;
                Total = Total + Amount;
                sb.Append("Order No. : " + kv.Key + "\n" + "Item : " + kv.Value.ItemName + "\n" + "Rate : " + kv.Value.Rate + "\n" + "Quantity : " + kv.Value.Quantity + "\n" + "Total Bill : " + Total + "\n");
                sb.Append("----------------" + "\n");
            }
            label5.Text = sb.ToString();
            MessageBox.Show("Total Amount " + Total);
        }
    }
}
