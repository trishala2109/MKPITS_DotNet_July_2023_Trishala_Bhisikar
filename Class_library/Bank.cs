using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;

namespace Bank_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Account act = null;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.Text == "Saving")
            {
                act = new Saving();
            }
            else if (comboBox1.Text == "Current")
            {
                act = new Current();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            act.AccountNo = Convert.ToInt32(textBox1.Text);
            string Result = act.Deposite(Convert.ToInt32(textBox2.Text));
            label4.Text = Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.AccountNo = Convert.ToInt32(textBox1.Text);
            string Result = act.Withdrwal(Convert.ToInt32(textBox2.Text));
            label4.Text = Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.AccountNo = Convert.ToInt32(textBox1.Text);
            string Result = act.ShowBalance();
            label4.Text = Result;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
