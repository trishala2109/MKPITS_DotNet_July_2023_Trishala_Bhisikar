using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subject_marks_print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phy, chem, math, total;
            float per;
            string grade = null;

            phy = Convert.ToInt32(textBox1.Text);
            chem = Convert.ToInt32(textBox2.Text);
            math = Convert.ToInt32(textBox3.Text);

            total = phy + chem + math;
            per = (total / 300.0f) * 100.0f;
            label4.Text = "Total = " + total;
            label5.Text = "Percentage = " + per;

            if (per >= 75)
                grade = "Distinction";
            else if (per >= 60 && per <= 75)
                grade = "First Class";
            else if (per >= 40 && per <= 60)
                grade = "Second Class";
            else
                grade = "Fail";
            label6.Text = "Grade = " + grade;
        }
    }
}
