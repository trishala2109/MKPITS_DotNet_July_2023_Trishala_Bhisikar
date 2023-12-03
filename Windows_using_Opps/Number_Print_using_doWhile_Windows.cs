using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Print_using_doWhile_Windows
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
            int n = Convert.ToInt32(textBox1.Text);
            int i = 1;
            do
            {
                sb.Append(i + "\n");
                i++;
            } while (i <= n);
            label4.Text = sb.ToString();
        }

    }
}
