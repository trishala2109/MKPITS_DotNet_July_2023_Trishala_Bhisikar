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

namespace Employee_Disconnect_Crude_operation
{
    public partial class frmEmployee : Form
    {
        string str = "server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = Company;";
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        public frmEmployee()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Employee", str);
            cb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds,"Emp");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Emp"];
        }
        //Create
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Emp"].NewRow();

            dr[0] = Convert.ToInt32(txtEmployeeID.Text);
            dr[1] = txtEmployeeName.Text;
            dr[2] = txtDOJ.Text;
            dr[3] = Convert.ToInt32(txtAge.Text);
            dr[4] = txtCity.Text;
            dr[5] = txtMobile.Text;
            dr[6] = Convert.ToInt32(txtSalary.Text);

            ds.Tables["Emp"].Rows.Add(dr);

            da.Update(ds.Tables["Emp"]);
            MessageBox.Show("Data Insert Successfully !");
        }
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in ds.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == txtEmployeeID.Text)
                {
                    try
                    {
                        dr[0] = Convert.ToInt32(txtEmployeeID.Text);
                        dr[1] = txtEmployeeName.Text;
                        dr[2] = txtDOJ.Text;
                        dr[3] = Convert.ToInt32(txtAge.Text);
                        dr[4] = txtCity.Text;
                        dr[5] = txtMobile.Text;
                        dr[6] = Convert.ToInt32(txtSalary.Text);

                        da.Update(ds.Tables["Emp"]);
                        MessageBox.Show("Data Update Successfully !");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == txtEmployeeID.Text)
                {
                    try
                    {
                        ds.Tables["Emp"].Rows.Remove(dr);
                        da.Update(ds.Tables["Emp"]);
                        MessageBox.Show("Data Delete Succesfully !");
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            txtEmployeeName.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            txtDOJ.Text = dataGridView1[2, e.RowIndex].Value.ToString(); ;
            txtAge.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            txtCity.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            txtMobile.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            txtSalary.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }
    }
}
