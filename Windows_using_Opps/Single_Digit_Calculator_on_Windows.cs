using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Single_Digit_Calculator_on_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int PreviousNo = 0;
        string Operator = null;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "+";
            Operator = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "-";
            Operator = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "*";
            Operator = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PreviousNo = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "/";
            Operator = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float Result = 0;
            switch (Operator)
            {   
                case "+":
                    Result = PreviousNo + Convert.ToInt32(textBox1.Text);
                    break;

                case "-":
                    Result = PreviousNo - Convert.ToInt32(textBox1.Text);
                    break;

                case "*":
                    Result = PreviousNo * Convert.ToInt32(textBox1.Text);
                    break;

                case "/":
                    if (PreviousNo != 0)
                    {
                        Result = PreviousNo / Convert.ToInt32(textBox1.Text);
                    }
                    else
                    {
                        Result = 0;
                    }
                    break;
            }
            textBox1.Text = Result.ToString();
        }
    }
}
