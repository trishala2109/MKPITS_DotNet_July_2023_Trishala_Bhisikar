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

namespace Collection_Queue_Student_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s1;
        Queue q = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            s1 = new Student(textBox1.Text,Convert.ToInt32(textBox2.Text));
            q.Enqueue(s1);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-------Before Dequeue------" + "\n");
            foreach(Student s1 in q)
            {
                sb.Append("Name : " + s1.Name + "\n" + "Roll No. " + s1.RollNo + "\n");
            }
            label3.Text = sb.ToString();

            q.Dequeue();
            sb.Append("-------After Dequeue------" + "\n");
            foreach (Student s1 in q)
            {
                sb.Append("Name : " + s1.Name + "\n" + "Roll No. " + s1.RollNo + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
