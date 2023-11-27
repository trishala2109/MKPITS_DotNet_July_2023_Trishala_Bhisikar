using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_Dictionary_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        Dictionary<int, string> li = new Dictionary<int, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.Add(Convert.ToInt32(textBox1.Text), textBox2.Text);
            clear();           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<int> Key = new List<int>(li.Keys);
            foreach (int key in Key)
            {
                sb.Append("Order : " + key + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(li.Values);
            foreach (string key in keys)
            {
                sb.Append("Items : " + key + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,string> kv in li)
            {
                sb.Append("Order : " + kv.Key + " Items = " + kv.Value + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
