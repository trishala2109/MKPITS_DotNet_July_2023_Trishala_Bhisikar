using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Dictionary_class_Employee_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Dictionary<int, Employee> EmployeeCollection = new Dictionary<int, Employee>();
        Employee emp = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
            EmployeeCollection.Add(emp.ID,emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,Employee> kv in EmployeeCollection)
            {
                sb.Append("Employee ID : " + kv.Key + "\n" + "Employee Name :  " + kv.Value.Name + "\n");
                sb.Append("--------------" + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
