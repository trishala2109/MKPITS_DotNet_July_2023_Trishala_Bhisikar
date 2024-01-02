using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = ado";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            try
            { 
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Connection Sucessfully !");

                string strcmd = "insert into Employee values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Data insert Successfully !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Connection Sucessfully !");

                string strcmd = "update Employee set EmployeeID = '" + textBox1.Text + "'Where EmployeeName = '" + textBox2.Text + "''" + textBox3.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Update Data Successfully !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Connection Sucessfully !");

                string strcmd = "delete from Employee Where EmployeeID = '" + textBox1.Text + "'or EmployeeName = '" + textBox2.Text + "''" + textBox3.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Delete Data Successfully !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Connection Sucessfully !");

                string strcmd = "select * from Employee Where EmployeeName = '" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, conn);

                int flag = 0;
                SqlDataReader dr;

                dr= command.ExecuteReader();

                while(dr.Read())
                {
                    flag = 1;
                    textBox1.Text = dr["EmployeeID"].ToString();
                }
                if(flag == 0)
                {
                    MessageBox.Show("Record Not Found !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
