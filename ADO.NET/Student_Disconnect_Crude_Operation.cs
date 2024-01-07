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

namespace Student_Disconnect_Crude_Operation
{
    public partial class frmStudent : Form
    {
        string str = "server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = Company;";
        DataSet dataSet = new DataSet();
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        public frmStudent()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("select * from Student", str);
            commandBuilder = new SqlCommandBuilder(adapter);
            dataSet= new DataSet();
            adapter.Fill(dataSet, "stud");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["stud"].NewRow();

            dr[0] = txtRollNo.Text;
            dr[1] = txtStudentName.Text;
            dr[2] = txtGender.Text;
            dr[3] = txtDOB.Text;
            dr[4] = txtClass.Text;
            dr[5] = txtCity.Text;
            dr[6] = txtEmail.Text;
            dr[7] = txtMobile.Text;

            dataSet.Tables["stud"].Rows.Add(dr);
            adapter.Update(dataSet.Tables["stud"]);
            MessageBox.Show("Data create Successfully.........");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["stud"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in dataSet.Tables["stude"].Rows)
            {
                if (dr[0].ToString() == txtRollNo.Text)
                {
                    try
                    {
                        dr[0] = txtRollNo.Text;
                        dr[1] = txtStudentName.Text;
                        dr[2] = txtGender.Text;
                        dr[3] = txtDOB.Text;
                        dr[4] = txtClass.Text;
                        dr[5] = txtCity.Text;
                        dr[6] = txtEmail.Text;
                        dr[7] = txtMobile.Text;

                        adapter.Update(dataSet.Tables["stud"]);
                        MessageBox.Show("Update data Succesfully");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRollNo.Text = dataGridView1[0,e.RowIndex].Value.ToString();
            txtStudentName.Text = dataGridView1[1,e.RowIndex].Value.ToString();
            txtGender.Text = dataGridView1[2,e.RowIndex].Value.ToString();
            txtDOB.Text = dataGridView1[3,e.RowIndex].Value.ToString();
            txtClass.Text = dataGridView1[4,e.RowIndex].Value.ToString();
            txtCity.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridView1[6,e.RowIndex].Value.ToString();
            txtMobile.Text = dataGridView1[7,e.RowIndex].Value.ToString();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
