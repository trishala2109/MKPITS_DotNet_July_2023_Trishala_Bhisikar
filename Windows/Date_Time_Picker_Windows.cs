using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Picker_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Text : " + dateTimePicker1.Text + "\n");
            sb.Append("Date in Interger : " + dateTimePicker1.Value.ToShortDateString() + "\n");
            sb.Append("Time Only : " + dateTimePicker1.Value.ToShortTimeString() + "\n");
            sb.Append("Date with Time : " + dateTimePicker1.Value.ToString() + "\n");

            label2.Text = sb.ToString();
 
        }
    }
}
