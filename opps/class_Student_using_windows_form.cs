using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Student_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] stud = new Student[10];
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Student();
            stud[1] = new Student();
            stud[2] = new Student();
            stud[3] = new Student();
            stud[4] = new Student();
            stud[5] = new Student();
            stud[6] = new Student();
            stud[7] = new Student();
            stud[8] = new Student();
            stud[9] = new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < 10)
            {
                stud[counter].Name = textBox1.Text;
                stud[counter].RollNo = Convert.ToInt32(textBox2.Text);
                stud[counter].Fees = Convert.ToInt32(textBox3.Text);
                stud[counter].Date =textBox4.Text;
                counter++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

                if(counter == 10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 10 Students accepted");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-----------------Students Detalis------------------" + "\n");
            for(int i = 0; i < 10; i++)
            {
                sb.Append("Student Name :- " + stud[i].Name + "\n");
                sb.Append("Roll No. :- " + stud[i].RollNo + "\n");
                sb.Append("Fees Paid :- " + stud[i].Fees + "\n");
                sb.Append("Date Paid Fees :- " + stud[i].Date + "\n");
                sb.Append("------------------------------------------------"+"\n");
            }
            label5.Text = sb.ToString();
            //-------------------------------
            StringBuilder sb1 = new StringBuilder();
            int high = stud[0].Fees;
            int found = 0;

            for(int i = 0; i < 10; i++)
            {
                if(high < stud[i].Fees)
                {
                    high = stud[i].Fees;
                    found = i;
                }
            }
            sb1.Append("Student Name :- " + stud[found].Name + "\n");
            sb1.Append("Roll No. :- " + stud[found].RollNo + "\n");
            sb1.Append("Fees Paid :- " + stud[found].Fees + "\n");
            sb1.Append("Date Paid Fees :- " + stud[found].Date + "\n");

            label6.Text = sb1.ToString();
        }
    }
}
