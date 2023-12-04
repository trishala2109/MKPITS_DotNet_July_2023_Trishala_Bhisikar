using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Employee_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmployeeName = textBox1.Text;
            int EmployeeID = Convert.ToInt32(textBox2.Text);
            int BasicSalary = Convert.ToInt32(textBox3.Text);
            float Bonus = BasicSalary * 0.45f;
            float TotalSalary = BasicSalary + Bonus;

            if (checkBox1.Checked)
            {
                label4.Text = "Bonus : " + Bonus;
            }
            else if (checkBox2.Checked)
            {
                label4.Text = "Total Salary : " + TotalSalary;
            }
        }
    }
}
