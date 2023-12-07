using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.MdiParent = this;
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login successfuly...");
                registerToolStripMenuItem.Enabled = true;
                existToolStripMenuItem.Enabled = true;
                withdrwalToolStripMenuItem.Enabled = true;
                depositeToolStripMenuItem.Enabled = true;
                balanceEnquieryToolStripMenuItem.Enabled = true;
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credential ! ");
            }
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void withdrwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSavingAccount sa = new frmSavingAccount();
            sa.MdiParent = this;
            sa.Show();
        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrentAccount ca = new frmCurrentAccount();
            ca.MdiParent = this;
            ca.Show();
        }

        private void balanceEnquieryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalanceEnquiry balenq = new frmBalanceEnquiry();
            balenq.MdiParent = this;
            balenq.Show();
        }
    }
}
