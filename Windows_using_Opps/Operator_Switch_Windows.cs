using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Switch_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operator o = new Operator();
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            string op = textBox3.Text;

            o.display(num1, num2,op);
            label4.Text = "Result = " + o.Result;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Switch_Windows
{
    class Operator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public string oper;
        public int Result;

        public void display(int Number1,int Number2,string oper)
        {
            this.Number1 = Number1;
            this.Number2 = Number2;
            this.oper = oper;
            
            switch(oper)
            {
                case "+" :
                    Result=Number1 + Number2;
                    break;

                case "-" :
                    Result = Number1 - Number2;
                    break;

                case "*" :
                    Result = Number1 * Number2;
                    break;

                case "/" :
                    Result = Number1 / Number2;
                    break;
            }
        }
    }
}
*/