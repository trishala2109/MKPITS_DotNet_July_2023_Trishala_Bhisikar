using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_in_search_index_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] number = new int[5];
        int counter=0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 5)
            {
                number[counter] = Convert.ToInt32(textBox1.Text);
                counter++;
                textBox1.Clear();
                textBox1.Focus();
                
                if (counter == number.Length)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("You are enter a 5 number choice any one number");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int index = 0;
            int num = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == num)
                {
                    flag = 1;
                    index = i + 1;
                    break;
                }
            }
            if (flag == 1)
            {
                label3.Text = "The position of number in an array = " + index;
            }
            else
            {
                label3.Text = "Number are not found";
            }
        }
    }
}
