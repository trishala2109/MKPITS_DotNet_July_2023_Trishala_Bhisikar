using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q1Answer = null;
            string q2Answer = null;
            string q3Answer = null;
            int Score = 0;

            if(radioButton1.Checked)
            {
                radioButton1.Text = "Delhi";
                Score++;
            }

            if (radioButton4.Checked)
            {
                radioButton4.Text = "Mumbai";
                Score++;
            }

            if (radioButton8.Checked)
            {
                radioButton8.Text= "Bhopal";
                Score++;
            }
 
            label6.Text = "Score = " + Score;
        }
    }
}

