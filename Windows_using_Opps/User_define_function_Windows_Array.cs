using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_define_function_Windows_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string[,] Album = new string[2, 2];
        StringBuilder sb = new StringBuilder();
        int Counter1 = 0;
        int Counter2 = 0;
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Counter1 < 2)
            {
                Album[Counter1, Counter2] = textBox1.Text;
                Album[Counter1, Counter2 + 1] = textBox2.Text;
                Counter1++;
                clear();
                if (Counter1 == 2)
                {
                    MessageBox.Show("2 values accepted");
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (Counter1 = 0; Counter1 < 2; Counter1++)
            {
                for (Counter2 = 0; Counter2 < 2; Counter2++)
                {
                    sb.Append(Album[Counter1, Counter2] + " \t ");
                }
                sb.Append("\n");
            }
            label3.Text = sb.ToString();

        }
    }
}
