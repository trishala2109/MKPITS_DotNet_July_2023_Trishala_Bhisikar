using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculatelibrary;

namespace Addition_and_Substarction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            int res = c.Addition (Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            label3.Text = "Addtion :- " + res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = c.Subtraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Subtraction :- " + res;
        }
    }
}