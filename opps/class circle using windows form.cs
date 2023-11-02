using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_circle_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circ = new Circle();
            float area, circum;
            circ.Radius = Convert.ToInt32(textBox1.Text);

            area = 3.14f * circ.Radius * circ.Radius;
            label2.Text = "Area of Circle " + area;

            circum = 2 * 3.14f * circ.Radius;
            label3.Text = "Area of Circle " + circum;
        }
    }
}
