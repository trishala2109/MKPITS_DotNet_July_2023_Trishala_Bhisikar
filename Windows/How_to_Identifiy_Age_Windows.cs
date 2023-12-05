using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_to_Identifiy_Age_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Age = dateTimePicker1.Text;
            MessageBox.Show("DOB : " + Age);
            
            string year = Age.Substring(5);
            int Year = dateTimePicker1.Value.Year;
            MessageBox.Show("DOB Year : " + Year);

            int CurrentYear = DateTime.Now.Year;
            MessageBox.Show("Current Yaer : " + CurrentYear);

            int Difference = CurrentYear - Convert.ToInt32(Year);
            MessageBox.Show("Your Age is : " + Difference);
            label2.Text = "Your Age is : " + Difference;
        }
    }
}
