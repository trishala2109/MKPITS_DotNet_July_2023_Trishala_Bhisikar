using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_used_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Balance = 1000;
            int ActNo = Convert.ToInt32(textBox1.Text);
            int Amount = Convert.ToInt32(textBox2.Text);
            if(radioButton1.Checked)
            {
                Balance = Balance + Amount;
            }
            else if (radioButton2.Checked)
            {
                Balance = Balance - Amount;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Account No. " + ActNo + "\n");
            sb.Append("Balance : " + Balance + "\n");
            label3.Text = sb.ToString();
        }
    }
}
