using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Factorial f = new Factorial();
        private void button1_Click(object sender, EventArgs e)
        { 
            int num = Convert.ToInt32(textBox1.Text);
            f.Fact(num);
            label2.Text = "Factorial of the Number is : " + f.fact;
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Windows
{
    class Factorial
    {
        public int Number { get; set; }
        public int fact=1;
        public void Fact(int Number)
        {
            while (Number > 0)
            {
                fact = fact * Number;
                Number--;
            }
        }
    }
}
*/
