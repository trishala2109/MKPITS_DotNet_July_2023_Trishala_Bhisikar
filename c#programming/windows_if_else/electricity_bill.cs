using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_bill
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UID, uname;
            int unit;
            float total, finalamt, chrg, surchrg;

            UID = textBox1.Text;
            uname = textBox2.Text;
            unit = Convert.ToInt32(textBox3.Text);

            if(unit >= 0 && unit <= 50)
            {
                chrg = 0.50f;
            }
            else if (unit > 50 && unit <= 150)
            {
                chrg = 0.75f;
            }
            else if (unit > 150 && unit <= 250)
            {
                chrg = 1.20f;
            }
            else
            {
                chrg = 1.50f;
            }

            total = chrg * unit;

            surchrg = total * 0.20f;

            finalamt = (total + surchrg);

            label4.Text = "Customer ID: " + UID;
            label5.Text = "Customer Name: " + uname;
            label6.Text = "Units Consumed: " + unit;
            label7.Text = "Charge Per Unit is @" + chrg + ".Rs and Total charge: " + total;
            label8.Text = "Surcharge: " + surchrg;
            label9.Text = "Final Amount: " + finalamt;
        }       
    }
}
