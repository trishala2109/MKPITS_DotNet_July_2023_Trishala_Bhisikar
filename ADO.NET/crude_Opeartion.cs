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

namespace Employee_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server =LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = ado;";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Connection Succesfully");
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            string Gender = null;
            if(radioButton1.Checked)
            {
                Gender = "Male";
            }
            else if(radioButton2.Checked)
            {
                Gender = "Female";
            }

            string Hobby = null;
            if (checkBox1.Checked)
            {
                Hobby = "Codeing";
            }
            else if(checkBox2.Checked)
            {
                Hobby = "Singing";
            }
            conn.Open();
            string result = "insert into Employe values ('"+ textBox1.Text +"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+Gender+"','"+comboBox1.Text+"','"+Hobby+"')";

            SqlCommand command=new SqlCommand(result,conn);
            command.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedItem = "";

            MessageBox.Show("Insert data Successfully !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            string Gender = null;
            if (radioButton1.Checked)
            {
                Gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                Gender = "Female";
            }

            string Hobby = null;
            if (checkBox1.Checked)
            {
                Hobby = "Codeing";
            }
            else if (checkBox2.Checked)
            {
                Hobby = "Singing";
            }
            conn.Open();
            string result = "update Employe set EmployeeName = '" + textBox2.Text + "'Designation ='" + textBox3.Text + "'Salary = '" + textBox4.Text + "'Gender = '" + Gender + "'City = '" + comboBox1.Text + "'Hobby = '" + Hobby + "' Where EmployeeID = '"+textBox1.Text+"'";

            SqlCommand command = new SqlCommand(result, conn);
            command.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedItem = "";

            MessageBox.Show("Update data Successfully !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            conn.Open();
            string result = "delete from Employe Where EmployeeID = '" + textBox1.Text + "'";

            SqlCommand command = new SqlCommand(result,conn);
            command.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedItem = "";

            MessageBox.Show("Delete Data successfully !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            try
            {

                conn.Open();
                string result = "select * from Employe Where EmployeeID = '" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(result, conn);
                SqlDataReader dr;

                int flag = 0;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["EmployeeName"].ToString();
                    textBox3.Text = dr["Designation"].ToString();
                    textBox4.Text = dr["Salary"].ToString();
                    MessageBox.Show("Record Found");
                }
                if (flag == 0)
                {
                    MessageBox.Show("Record not found !");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
