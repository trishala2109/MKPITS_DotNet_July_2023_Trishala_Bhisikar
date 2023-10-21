using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace even_odd_no
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
           
            num = Convert.ToInt32(textBox1.Text);

            if(num %  2 == 0)
            {
                label2.Text = "The number is even " + num;
            }
            else
            {
                label2.Text = "The number is odd " + num;
            }
        }
    }
}
