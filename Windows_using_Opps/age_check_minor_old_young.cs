using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_check_minor_old_young
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Check_age a = new Check_age();
        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text);
            a.display(age);
            label2.Text = a.Result;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_check_minor_old_young
{
    internal class Check_age
    {
        public int Age;
        public string Result;
        public void display(int Age)
        {
            if(Age < 18 )
            {
                Result = "This is a minor";
            }
            else if ( Age >=18 && Age <= 40)
            {
                Result = "This is a Young";
            }
            else 
            {
                Result = "This is a Old";
            }
        }
    }
}
*/