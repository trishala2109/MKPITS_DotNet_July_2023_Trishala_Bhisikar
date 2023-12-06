using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_form
{
    public partial class frmAddmission : Form
    {
        public frmAddmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();

            string name = textBox1.Text;
            sb.Append("First Name : " + name + "\n");

            string middlename = textBox2.Text;
            sb.Append("Middle Name : " + middlename + "\n");

            string lastname = textBox3.Text;
            sb.Append("Last Name : " + lastname + "\n");

            string dob = dateTimePicker1.Value.ToString();
            sb.Append("DOB : " + dob);

            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                gender = radioButton3.Text;
            }
            sb.Append("Gender : " + gender + "\n");

            string course = comboBox1.Text;
            switch (course)
            {
                case "Civil Enginnering":
                    break;

                case "Mechanical Enginnering":
                    break;

                case "Computer Enginnering":
                    break;

                case "IT Enginnering":
                    break;

                case "Electronic Enginnering":
                    break;

                case "Electrical Enginnering":
                    break;
            }
            sb.Append("Course : " + course + "\n");

            label8.Text = sb.ToString();
        }
    }
}
