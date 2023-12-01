using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Show_the_Result
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        marks m = new marks();
        private void button1_Click(object sender, EventArgs e)
        {
            float subject1 = Convert.ToInt32(textBox1.Text);
            float subject2 = Convert.ToInt32(textBox2.Text);
            float subject3 = Convert.ToInt32(textBox3.Text);
            m.TotalMarks(subject1, subject2, subject3);
            label4.Text = "Total marks is : " + m.Total;
            label5.Text = "percentage = " + m.Percentage;
            label6.Text = "" + m.Grade;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_the_Result
{
    internal class marks
    {
        public float Subject1 { get; set; }
        public float Subjcet2 { get; set; }
        public float Subject3 { get; set; }
        public float Percentage;
        public float Total;
        public string Grade;
        public void TotalMarks(float Subjcet1,float Subject2,float Subject3)
        {
            Total = Subjcet1 + Subject2 + Subject3;            
        
            Percentage = Total / 300 * 100;
            
            if (Percentage >= 75)
            {
                Grade = "Grade = A";
            }
            else if (Percentage <= 75 && Percentage >= 60)
            {
                Grade = "Grade = B";
            }
            else
            {
                Grade = "Grade = C";
            }
            
        }
    }
}
*/