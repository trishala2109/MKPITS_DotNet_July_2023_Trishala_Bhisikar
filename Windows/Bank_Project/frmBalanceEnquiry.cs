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
    public partial class frmBalanceEnquiry : Form
    {
        public frmBalanceEnquiry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Account No. : " + Convert.ToInt32(textBox1.Text) + "\n");
            sb.Append("Account Holder Name : " + textBox2.Text + "\n");

            string type = null;
            int Balance = 1000;

            if(radioButton1.Checked)
            {
                type = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                type = radioButton2.Text;
            }
            sb.Append("Account Type : " + type + "\n");

            if (type == "Saving")
            {
                int Intrest = 500;
                Balance = Balance + Intrest;
                sb.Append("Balance of Saving account is : " + Balance + "\n");
            }
            else if(type == "Current")
            {
                sb.Append("Balance of Current account is : " + Balance + "\n");
            }

            label4.Text = sb.ToString();
        }
    }
}
