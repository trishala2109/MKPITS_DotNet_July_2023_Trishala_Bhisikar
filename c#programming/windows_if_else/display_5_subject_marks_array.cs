using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_5_subject_marks_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] marks = new int[3];
        int total = 0;
        float percentage = 0;
        int counter;
        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < marks.Length )
            {
                marks[counter] = Convert.ToInt32(textBox1.Text);
                counter++;
                textBox1.Clear();
                textBox1.Focus();

                if(counter == marks.Length)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("The 3 subject marks are entered plz click the submit button ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < marks.Length; i ++)
            {
                total = total + marks[i];
            }
            label2.Text = "Total = " + total;
            percentage = (total / 300.0f) * 100.0f;
            label3.Text = "Percentage = " + percentage;
        }
    }
}
