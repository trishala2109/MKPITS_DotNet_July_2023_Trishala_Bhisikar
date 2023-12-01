using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.Number = Convert.ToInt32(textBox1.Text);
            s.display(s.Number);
            label2.Text = "Square : " + s.Result;        
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Windows
{
    class Square
    {
        public int Number { get; set; }
        public int Result;
        public void display(int Number)
        {
            Result = Number * Number;
            
        }
    }
}
*/

