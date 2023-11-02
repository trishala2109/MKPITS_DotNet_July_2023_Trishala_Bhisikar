using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Libarary_Book_using_Windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LibraryBook[] book = new LibraryBook[3];
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < 3)
            {
                book[counter].Title = textBox1.Text;
                book[counter].Author = textBox2.Text;

                if(checkBox1.Checked)
                {
                    book[counter].IsAvailabe = true;
                }
                counter++;
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                if(counter == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 3 Books accepted");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new LibraryBook();
            book[1] = new LibraryBook();
            book[2] = new LibraryBook();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Available books are : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].IsAvailabe == true)
                {
                    sb.Append("----------------------------------------\n");
                    sb.Append("title: " + book[i].Title + "\n");
                    sb.Append("author : " + book[i].Author + "\n");

                    sb.Append("----------------------------------------\n");
                }
            }
            label3.Text = sb.ToString();
        }
    }
}
