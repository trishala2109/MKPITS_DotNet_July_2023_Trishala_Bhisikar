using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leep_years
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;

            year = Convert.ToInt32(textBox1.Text);

            if (year % 4 == 0)
            {
                label2.Text = "This is leep year " + year;
            }
            else
            {
                label2.Text = "This is not leep year" + year;
            }
        }
    }
}
