using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int salary = Convert.ToInt32(textBox2.Text);
            string designation = textBox3.Text;

            emp.displayDetails(name, salary, designation);

            label4.Text = "HRA : " + emp.HRA;
            label5.Text = "Bonus : " + emp.Bonus;
            label6.Text = "Total Salary : " + emp.TotalSalary;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Windows
{
    class Employee
    {
        string EmployeeName { get; set; }
        public int BasicSalary { get; set; }
        public string Desigantion { get; set; }

        public float HRA;
        public float Bonus;
        public float TotalSalary;
        public void displayDetails(string EmployeeName,int BasicSalary,string Designation)
        {
            this.EmployeeName = EmployeeName;
            this.BasicSalary = BasicSalary;
            this.Desigantion = Designation;

            switch (Desigantion)
            {
                case "Manager":
                    HRA = BasicSalary * 0.35f;
                    Bonus = BasicSalary * 0.5f;
                    break;

                case "Clerk":
                    HRA = BasicSalary * 0.25f;
                    Bonus = BasicSalary * 0.03f;
                    break;

                case "Peon":
                    HRA = BasicSalary * 0.20f;
                    Bonus = BasicSalary * 0.02f;
                    break;
            }
            TotalSalary = HRA * Bonus * BasicSalary;
        }
    }
}
*/