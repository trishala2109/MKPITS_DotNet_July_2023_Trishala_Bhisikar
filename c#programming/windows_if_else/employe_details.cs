using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employe_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empno, basicsalary;
            string empname, designation;
            float total = 0, bonus = 0;

            empno = Convert.ToInt32(textBox1.Text);
            empname = Convert.ToString(textBox2.Text);
            designation = Convert.ToString(textBox3.Text);
            basicsalary = Convert.ToInt32(textBox4.Text);

            if (designation == "maneger")
            {
                bonus = basicsalary * 0.55f;
            }
            else if (designation == "clerk")
            {
                bonus = basicsalary * 0.25f;
            }
            else if (designation == "peon")
            {
                bonus = basicsalary * 0.10f;
            }
            else
            {
                throw new Exception("invalid");
            }
            total = bonus + basicsalary;
            label5.Text = "Employe ID = " + empno;
            label6.Text = "Employe Name = " + empname;
            label7.Text = "Employe Designation = " + designation;
            label8.Text = "Employe Basic Salary = " + basicsalary;
            label9.Text = "Employe Bonus = " + bonus;
            label10.Text = "Calculate Basic Salary With Bonus " + total;
            
        }
    }
}
