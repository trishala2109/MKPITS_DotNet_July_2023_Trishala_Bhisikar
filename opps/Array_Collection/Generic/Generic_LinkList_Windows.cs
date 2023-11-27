using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_LinkList_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void display()
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in li)
            {
                sb.Append("Course Name : " + s + "\n");
            }
            label3.Text = sb.ToString();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        static LinkedList<string> li = new LinkedList<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.AddLast(textBox1.Text);
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            li.AddFirst(textBox1.Text);
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedListNode<string> node = li.Find(textBox1.Text);
            li.AddAfter(node,textBox2.Text);
            clear();
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkedListNode<string> node = li.Find(textBox1.Text);
            li.AddBefore(node, textBox2.Text);
            clear();
            display();
        }
    }
}
