using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Product_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();

            pro.ProductName = textBox1.Text;
            pro.Price = Convert.ToInt32(textBox2.Text);
            pro.Quantity = Convert.ToInt32(textBox3.Text);

            int total, stock = 100;
            if(pro.Quantity > 0 && pro.Quantity < stock)
            {
                int remainingstock = stock - pro.Quantity;
                total = pro.Price * pro.Quantity;

                label4.Text = "Total Price You Purches :- " + total;
                label5.Text = "Reamaning stock Quantity :- " + remainingstock;
            }
            
        }
    }
}
