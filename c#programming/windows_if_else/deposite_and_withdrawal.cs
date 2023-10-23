using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deposite_and_withdrawal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acntno, bal = 1000, amt, deposite, withdrwal;
            string name;
            

            acntno = Convert.ToInt32(textBox1.Text);
            name = (textBox2.Text);
            amt = Convert.ToInt32(textBox3.Text);

        
                if (radioButton1.Checked)
                {

                deposite = amt + bal;
                label9.Text = "Account no. : " + acntno;
                label8.Text = "Account Holder's Name: " + name;
                label5.Text = "Iniatial Balance: " + bal;
                label6.Text = "Total Balance: " + deposite;

                }

                else
                {
                    withdrwal = bal - amt;
                    label9.Text = "Account no. : " + acntno;
                    label8.Text = "Account Holder's Name: " + name;
                    label5.Text = "Iniatial Balance: " + bal;
                    label6.Text = "Total Balance: " + withdrwal;
                }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
