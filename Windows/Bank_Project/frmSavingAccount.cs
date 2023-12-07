using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class frmSavingAccount : Form
    {
        public frmSavingAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int Balance = 1000;
            int Intreset = 500;
            sb.Append("Account No. : " + Convert.ToInt32(textBox1.Text) + "\n");
            sb.Append("Amount : " + Convert.ToInt32(textBox2.Text) + "\n");

            if(radioButton1.Checked)
            {
                Balance = Balance + Convert.ToInt32(textBox2.Text) + Intreset;
                sb.Append("Deposite Amount of Saving account is : " + Balance + "\n");
            }
            else if(radioButton2.Checked)
            {
                Balance = Balance - Convert.ToInt32(textBox2.Text);
                sb.Append("Withdrwal Amount of Saving account is : " + Balance + "\n");
            }
            
            label4.Text = sb.ToString();
        }
    }
}
