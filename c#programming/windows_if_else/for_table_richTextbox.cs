using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_table_richTextbox
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
            int number, counter, result = 1;
            number = Convert.ToInt32(textBox1.Text);

            for(counter=1;counter<=10;counter++)
            {
                result = number * counter;
                sb.Append(number + "*" + counter + "=" + result + "\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
