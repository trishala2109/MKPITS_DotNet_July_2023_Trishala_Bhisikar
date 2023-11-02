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

namespace class_Employe_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 3)
            {
                emp[counter].EmployeID = Convert.ToInt32(textBox1.Text);
                emp[counter].EmployeName = textBox2.Text;
                emp[counter].Salary = Convert.ToInt32(textBox3.Text);
                counter++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (counter == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("you will add 3 employee Details click the Submit ");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("---------------------Employee Details----------------- "+"\n");
            for(int i =0; i < 3; i++)
            {
                sb.Append("Employee ID :- "+ emp[i].EmployeID + "\n");
                sb.Append("Employee Name :- " + emp[i].EmployeName + "\n");
                sb.Append("Employee Salary :- " + emp[i].Salary + "\n");
                sb.Append("----------------------------------------------"+"\n");
            }
            
            label4.Text = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            int found = 0;
            int high = emp[0].Salary;

            for (int i = 0; i < 3; i++)
            {
                if (high < emp[i].Salary)
                {
                    high = emp[i].Salary;
                    found = i;
                }
            }

              sb1.Append("Employee ID :- " + emp[found].EmployeID + "\n");
              sb1.Append("Employee Name :- " + emp[found].EmployeName + "\n");
              sb1.Append("Employee Salary :- " + emp[found].Salary + "\n");
              sb1.Append("----------------------------------------------"+"\n");

             label5.Text = sb1.ToString();
        }
    }
}
