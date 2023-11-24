using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment_1_Stack_Employee_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp;
        Stack st = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            emp = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            st.Push(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-----Before Poping------" + "\n");
            foreach(Employee emp in st)
            {
                sb.Append("employee Id : "+emp.EmployeeID+"\n"+"Name : "+emp.Name+"\n"+"Designation : "+emp.Designation+"\n"+"Salary :"+emp.Salary+ "\n");
            }
            label5.Text = sb.ToString();

            st.Pop();
            sb.Append("-----Before Poping------" + "\n");
            foreach (Employee emp in st)
            {
                sb.Append("employee Id : " + emp.EmployeeID + "\n" + "Name : " + emp.Name + "\n" + "Designation : " + emp.Designation + "\n" + "Salary :" + emp.Salary + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
