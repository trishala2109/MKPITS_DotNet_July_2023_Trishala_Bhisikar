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

namespace Connections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "server = LAPTOP-9RQBBG2R\\SQLEXPRESS;integrated security = true; database =ado";
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Connection Succesfully");
                string strcmd = "insert into Users values ('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Insert the data Succesfully !");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Connection Succesfully");
                string strcmd = "update Users set Passwords = '" + textBox2.Text + "' Where Username = '" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("record update Succesfully !");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con = new SqlConnection(str);
                con.Open();
         
                string strcmd = "delete from Users Where Username = '" + textBox1.Text + "' or Passwords = '" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Delete the data Succesfully !");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con = new SqlConnection(str);
                con.Open();

                string strcmd = "Select * from Users Where Username = '" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);

                SqlDataReader dr;
                int flag = 0;

                dr= command.ExecuteReader();
                while(dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Passwords"].ToString();
                }
                if(flag==0)
                {
                    MessageBox.Show("Record not found");
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
            finally
            {
                con.Close();
            }
        }
    }
}
