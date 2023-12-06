using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login successfuly...");
                addmissionFormToolStripMenuItem.Enabled = true;
                enquireyFormToolStripMenuItem.Enabled = true;
                addmissionFormToolStripMenuItem.Enabled = true;
                contactUsToolStripMenuItem.Enabled = true;
                aboToolStripMenuItem.Enabled = true;
                existToolStripMenuItem.Enabled = true;
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credential ! ");
            }
           
        }

        private void addmissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddmission ad = new frmAddmission();
            ad.MdiParent = this;
            ad.Show();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enquireyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnquiry enq = new frmEnquiry();
            enq.MdiParent = this;
            enq.Show();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddmission ad = new frmAddmission();
            ad.MdiParent = this;
            ad.Show();
        }

        private void enquiryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnquiry enq = new frmEnquiry();
            enq.MdiParent = this;
            enq.Show();
        }
    }
}
