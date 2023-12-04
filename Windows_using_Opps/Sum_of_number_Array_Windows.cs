using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_of_number_Array_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[5];
        int sum = 0;
        int Counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           
            if (Counter < 5)
            {
                num[Counter] = Convert.ToInt32(textBox1.Text);
                sum = sum + num[Counter];
                Counter++;
                textBox1.Clear();
                textBox1.Focus();
            }
            label2.Text ="Sum of No. is : " + sum.ToString();
        }
    }
}
