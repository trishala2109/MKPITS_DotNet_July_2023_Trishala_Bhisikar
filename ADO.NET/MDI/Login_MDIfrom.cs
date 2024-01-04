using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database=ado;";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str);
                string result = "select count (*) from Users Where Username = @Username AND Passwords = @Passwords ";

                SqlCommand command = new SqlCommand(result, conn);

                command.Parameters.AddWithValue("@Username", textBox1.Text);
                command.Parameters.AddWithValue("@Passwords", textBox2.Text);

                conn.Open();

                int Counter = Convert.ToInt32(command.ExecuteScalar());
                if (Counter > 0)
                {
                    MessageBox.Show("Login Sucessfully !");
                    panel1.Visible = false;
                    menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid Credential !");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.MdiParent = this;
            emp.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent stud = new frmStudent();
            stud.MdiParent = this;
            stud.Show();
        }
    }
}
