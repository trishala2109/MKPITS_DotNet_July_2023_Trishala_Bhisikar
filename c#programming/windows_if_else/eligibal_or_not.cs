using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eligibal_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;

            age = Convert.ToInt32(textBox1.Text);

            if (age >= 18)
            {
                label2.Text = "This person are Eligibal for vote";
            }
            else
            {
                label2.Text = "This person are not Eligival for vote";
            }
        }
    }
}
