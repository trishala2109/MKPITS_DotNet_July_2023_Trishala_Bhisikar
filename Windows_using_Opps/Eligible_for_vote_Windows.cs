using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eligible_for_vote_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        age a = new age();
        private void
        button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            a.display(num1);
            label2.Text = "" + a.Result;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eligible_for_vote_Windows
{
    class age
    {
        public int Age;
        public string Result;
        public void display(int Age)
        {
            if (Age >= 18)
            {
                Result = "It is Eligibale for vote";
            }
            else
            {
                Result = "It is not eligible for vote";
            }
        }
    }
}
*/