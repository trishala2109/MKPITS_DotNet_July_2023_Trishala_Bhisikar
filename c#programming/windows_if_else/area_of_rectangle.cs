using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_of_reactangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l, b, area;
            l = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            area = l * b;
            label3.Text = "Area of Rectangle = " + area;

        }
    }
}
