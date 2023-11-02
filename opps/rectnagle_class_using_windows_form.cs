using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rectnagle_class_using_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangel rect = new Rectangel();

            rect.width = Convert.ToInt32(textBox1.Text);
            rect.height = Convert.ToInt32(textBox2.Text);

            rect.area = rect.width * rect.height;

            StringBuilder sb = new StringBuilder();
            sb.Append("Area of Reactangle :-  " + rect.area);
            label3.Text = sb.ToString();   
        }
    }
}
