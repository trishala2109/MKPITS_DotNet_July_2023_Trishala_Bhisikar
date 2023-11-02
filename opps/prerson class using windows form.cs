using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prerson_class_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personcs per = new Personcs();

            per.Name = textBox1.Text;
            per.Age = Convert.ToInt32(textBox2.Text);
            per.Adress = textBox3.Text;

            StringBuilder sb = new StringBuilder();

            sb.Append("Name :- " + per.Name + "\n");
            sb.Append("Age :- " + per.Age + "\n");
            sb.Append("Address :- " + per.Adress+ "\n");

            label4.Text = sb.ToString();
        }
    }
}
