using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empName = textBox1.Text;
            int BasicSalary = Convert.ToInt32(textBox2.Text);
            string Designation = comboBox1.Text;

            double TotalSalary = 0;
            double Bonus = 0 ;

            switch(Designation)
            {
                case "Manager":
                    Bonus = BasicSalary + 0.45;
                    break;

                case "Clerk":
                    Bonus = BasicSalary + 0.25;
                    break;

                case "Peon":
                    Bonus = BasicSalary + 0.15;
                    break;
            }

            TotalSalary = BasicSalary + Bonus;
            if (checkBox1.Checked)
            {
                label4.Text = "Bonus : " + Bonus;
            }
            else if (checkBox2.Checked)
            {
                label4.Text = "Total Slary : " + TotalSalary;
            }
        }
    }
}
