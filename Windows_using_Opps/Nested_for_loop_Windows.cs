using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nested_for_loop_Windows
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
            int i,j;
            for(i = 1; i <= 3; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    sb.Append(j + "  ");
                }
                sb.Append("\n");
            }
            label4.Text=sb.ToString();
        }
    }
}