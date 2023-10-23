using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distance___speed
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float dist, hr, min, sec, timesec;
            float metersec, km, miles;

            dist = Convert.ToSingle(textBox1.Text);
            hr = Convert.ToSingle(textBox2.Text);
            min = Convert.ToSingle(textBox3.Text);
            sec = Convert.ToSingle(textBox4.Text);

            timesec = (hr * 3600) + (min * 60) + sec;
            metersec = dist / timesec;
            km = (dist / 1000.0f) / (timesec / 3600);
            miles = km / 1.60934f;

            label5.Text = "Speed in meters/sec is: " + metersec;
            label6.Text = "Speed in km/h is: " + km;
            label7.Text = "Speed in miles/h is: " + miles;

        }
    }
}
