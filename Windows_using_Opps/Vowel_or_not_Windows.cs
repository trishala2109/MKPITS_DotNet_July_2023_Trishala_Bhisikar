using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowel_or_not_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Vowel v = new Vowel();
        private void button1_Click(object sender, EventArgs e)
        {
            v.vowel = Convert.ToChar(textBox1.Text);
            v.display(v.vowel);
            label2.Text = v.Result;
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_not_Windows
{
    class Vowel
    {
        public char vowel;
        public string Result;
        public void display(char vowel)
        {
            switch(vowel)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Result = "It is Vowels";
                    break;

                default:
                   Result = "It is Cansonant";
                    break;
            }
        }
    }
}
*/