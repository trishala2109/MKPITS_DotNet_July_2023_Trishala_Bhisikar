using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposite_withdrwal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            string type = textBox2.Text;
            if(type == "Saving")
            {
                act = new Saving();
            }
            else if(type == "Current")
            {
                act = new Current();
            }

            label4.Text = act.Deposite(actno, amount);
            label5.Text = act.ShowBalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            string type = textBox2.Text;
            if (type == "Saving")
            {
                act = new Saving();
            }
            else if (type == "Current")
            {
                act = new Current();
            }

            label4.Text = act.Withdrawl(actno, amount);
            label5.Text = act.ShowBalance();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
