using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_y_z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z, result1, result2;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);

            result1 = (x + y) * z;
            result2 = (x * y) + (y * z);

            label4.Text = "( x + y ) * z = " + result1;
            label5.Text= "( x * y ) + ( y * z ) = " + result2;
        }
    }
 }


