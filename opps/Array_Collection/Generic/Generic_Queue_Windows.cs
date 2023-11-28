using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Queue_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<string> q = new Queue<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            q.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("--------Enqueue-------" + "\n");
            foreach (string s in q)
            {
                sb.Append("Name : " + s + "\n");
            }
            label2.Text = sb.ToString();

            q.Dequeue();
            sb.Append("--------Dequeue-------" + "\n");
            foreach (string s in q)
            {
                sb.Append("Name : " + s + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
