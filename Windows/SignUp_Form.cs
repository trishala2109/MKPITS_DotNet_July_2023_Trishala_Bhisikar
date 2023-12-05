using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";

            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Delhi");
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Jaipur");
                    comboBox2.Items.Add("Bhopal");
                    comboBox2.Items.Add("Banglor");
                    break;

                case "USA":
                    comboBox2.Items.Add("Londan");
                    comboBox2.Items.Add("New york");
                    comboBox2.Items.Add("Californiya");
                    comboBox2.Items.Add("Disney land");
                    break;

                case "Pakistan":
                    comboBox2.Items.Add("Afganistan");
                    comboBox2.Items.Add("Lahor");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("UserName : " + textBox1.Text + "\n");
            sb.Append("Password : " + textBox2.Text + "\n");

            string Gender = null;
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                Gender = radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                Gender = radioButton3.Text;
            }
            sb.Append("Gender : " + Gender + "\n");

            string Course = null;
            if(checkBox1.Checked)
            {
                Course = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                Course = Course + " " + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                Course = Course + " " + checkBox3.Text;
            }
            sb.Append("Courses : " + Course + "\n");
            sb.Append("Country : " + comboBox1.Text + "\n");
            sb.Append("City : " + comboBox2.Text + "\n");
            label7.Text = sb.ToString();
        }
    }
}
