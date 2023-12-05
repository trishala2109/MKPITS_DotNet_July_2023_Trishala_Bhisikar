using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyperlink_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hello From LableLink");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Courses : " + listBox1.SelectedItem.ToString();
            label2.Text = "Phone Number : " + maskedTextBox1.SelectionStart.ToString();
        }
    }
}
