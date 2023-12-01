using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smallest_no_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        smallest_no s = new smallest_no();
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            s.Display(num1, num2);
            label3.Text = "" + s.Result;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_no_windows
{
    internal class smallest_no
    {
        int Number1 { get; set; }
        int Number2 { get; set; }
        public string Result;
        public void Display(int Number1,int Number2)
        {
            if(Number1 < Number2)
            {
                Result = "Number 1 is smaller";
            }
            else
            {
                Result = "Number 2 is smaller";
            }
        }
    }
}
*/