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

namespace Collection_Stack_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack st = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            st.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-----Before Poping---------"+"\n");
            foreach(string s in st)
            {
                sb.Append("Name : "+ s + "\n" );
            }
            label2.Text = sb.ToString();

            st.Pop();
            sb.Append("-----After Poping---------"+"\n");
            foreach (string s in st)
            {
                sb.Append("Name : " + s + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
