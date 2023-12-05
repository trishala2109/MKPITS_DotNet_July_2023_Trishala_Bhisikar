using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string Name = textBox1.Text;
            decimal Age = Convert.ToInt32(numericUpDown1.Value.ToString());

            if(textBox1.Text == "" && numericUpDown1.Value == 0)
            {
                MessageBox.Show("Enter a Name");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Enter a Name");
            }

            if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("Enter Age");
            }
            else if (Age <= 18 || Age >= 99)
            {
                MessageBox.Show("Enter Age should be 18 to 99 year");
            }

            sb.Append("Name: " + Name + "\n");
            sb.Append("Age : " + Age + "\n");
            label3.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }
    }
}
