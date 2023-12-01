using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_substraction_multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {          
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            c.Addition(num1,num2);
            label3.Text = "Addition : " + c.Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            c.Substraction(num1, num2);
            label3.Text = "Addition : " + c.Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            c.Multiplication(num1, num2);
            label3.Text = "Addition : " + c.Result;
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_substraction_multiplication
{
    class Calculate
    {
        int Number1 { get; set; }
        int Number2 { get; set; }
        public int Result;
        public void Addition(int Number1,int Number2)
        {
            Result = Number1 + Number2;
        }
        public void Substraction(int Number1, int Number2)
        {
            Result = Number1 - Number2;
        }
        public void Multiplication(int Number1, int Number2)
        {
            Result = Number1 * Number2;
        }
    }
}
*/
