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

namespace Class_books_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Books[] book = new Books[3];
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new Books();
            book[1] = new Books();
            book[2] = new Books();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(counter < 3)
            {
                book[counter].Title = textBox1.Text;
                book[counter].Author = textBox2.Text;
                book[counter].Year = Convert.ToInt32(textBox3.Text);
                counter++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (counter == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled=false;
                    textBox2.Enabled=false;
                    textBox3.Enabled=false;
                    

                    MessageBox.Show("The Books entery is done");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 3; i++)
            {
                sb.Append("--------------------------------------"+"\n");
                sb.Append("Book Titel" + book[i].Title+"\n");
                sb.Append("Book Author Name :- " + book[i].Author + "\n");
                sb.Append("Publication Year :- " + book[i].Year + "\n");
                sb.Append("--------------------------------------"+"\n");
            }

            label4.Text = sb.ToString();
        }
    }
}
