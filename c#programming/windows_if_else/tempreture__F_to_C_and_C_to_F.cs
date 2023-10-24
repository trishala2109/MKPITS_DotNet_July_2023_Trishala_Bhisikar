using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempreture__F_to_C_and_C_to_F_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float temp, F;
            temp = float.Parse(textBox1.Text);

            F = (temp - 32) *5 / 9; // Convert ( Celsius to Fahrenheit ) 

            label2.Text = "Fahrenheit to Celsius: " + F + " °C";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float temp, C;
            temp = float.Parse(textBox1.Text);

            C = (temp * 9 / 5) + 32; // Convert ( Fahrenheit to Celsius) 

            label2.Text = "Celsius to Fahrenheit: " + C + " °F";
        }
    }
}
