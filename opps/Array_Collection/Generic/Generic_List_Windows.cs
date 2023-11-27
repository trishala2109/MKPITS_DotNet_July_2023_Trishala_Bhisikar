using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_List_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        List<string> li = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.Add(textBox1.Text);
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in li)
            {
                sb.Append("Course Name : " + s + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            li.Remove(textBox1.Text);
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            li.Insert(2,textBox1.Text);
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            li.Sort();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(li.Contains(textBox1.Text))
            {
                label2.Text = "Found in Collections";
            }
            else
            {
                label2.Text = "It is not in Collections";
            }
            clear();
        }
    }
}
