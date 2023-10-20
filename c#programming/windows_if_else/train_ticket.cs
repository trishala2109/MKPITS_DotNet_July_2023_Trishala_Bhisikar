using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace train_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string origin = "nagpur", date, compartment, destination, name;
            int trainno, amount;

            origin = Convert.ToString(textBox1.Text);
            destination = Convert.ToString(textBox2.Text);
            name = Convert.ToString(textBox3.Text);
            compartment = Convert.ToString(textBox4.Text);
            trainno = Convert.ToInt32(textBox5.Text);
            date = Convert.ToString(textBox6.Text);

            if(destination == "Bhopal")
            {
                amount = 500;
            }
            else if (destination == "Mumbai")
            {
                amount = 800;
            }
            else if (destination == "Delhi")
            {
                amount = 1000;
            }
            else
            {
                amount = 1500;
            }
            label7.Text = "Train Origin : " + origin;
            label8.Text = "Train Destination : " + destination;
            label9.Text = "Passenger Name : " + name;
            label10.Text = "Compartment (AC, Sleeper, Genral) :" + compartment;
            label11.Text = "Trin No. : " + trainno;
            label12.Text = "Travelling Date :" + date;
            label13.Text = "Total Ticket Amount :" + amount;
        }
    }
}
