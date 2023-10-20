using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coordinate_point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            if(x>0 && y>0)
            {
                label3.Text="The Co-ordinate point lies in the first quadrant "+ x + " " + y;
            }
            else if (x<0 && y>0)
            {
                label3.Text = "The Co-ordinate point lies in the Second quadrant " + x + " " + y;
            }
            else if (x<0 && y<0)
            {
                label3.Text = "The Co-ordinate point lies in the third quadrant " + x + " " + y;
            }
            else if(x>0 && y<0)
            {
                label3.Text = "The Co-ordinate point lies in the fourth quadrant " + x + " "+ y;
            }
            
        }
    }
}
