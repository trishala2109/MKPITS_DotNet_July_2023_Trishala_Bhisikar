using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayNo_and_DayName_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Day d = new Day();
        private void button1_Click(object sender, EventArgs e)
        {
            d.DayNo = Convert.ToInt32(textBox1.Text);
            d.display(d.DayNo);
            label2.Text = d.DayName;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNo_and_DayName_Windows
{
    class Day
    {
        public int DayNo;
        public string DayName;
        public void display(int DayNo)
        {
            switch(DayNo)
            {
                case 1:
                   DayName = "Monday";
                    break;
                case 2:
                    DayName = "Tuesday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                case 4:
                    DayName = "Thursday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;
                case 6:
                    DayName = "Saturday";
                    break;
                case 7:
                    DayName = "Sunday";
                    break;
            }
        }
    }
}
*/