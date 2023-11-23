using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Array_Collection_remove_method_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            ar.Add(Name);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(object obj in ar)
            {
                sb.Append("Name : " + obj.ToString() + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(textBox2.Text);
            ar.RemoveAt(position);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(textBox2.Text);
            ar.Insert(position, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
