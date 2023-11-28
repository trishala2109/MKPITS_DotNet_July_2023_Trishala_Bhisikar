using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Stack_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> s = new Stack<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            s.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("--------push-------" + "\n");
            foreach (string name in s)
            {
                sb.Append("Name : " + name + "\n");
            }
            label2.Text = sb.ToString();

            s.Pop();
            sb.Append("--------Dequeue-------" + "\n");
            foreach (string name in s)
            {
                sb.Append("Name : " + name + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
