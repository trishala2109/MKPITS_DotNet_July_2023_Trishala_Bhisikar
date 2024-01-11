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

namespace Product_Fendal_Quetions
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        string str = "Server = LAPTOP-9RQBBG2R\\SQLEXPRESS; Integrated Security = True; Database = Registration Course;";
        SqlConnection conn;
        DataSet dataset;
        SqlDataAdapter adapter;

        public enum Nationality { Indian,NRI}
        private void frmProduct_Load(object sender, EventArgs e)
        {
            getCategoryProduct();
            getProduct();
            getPrice();
        }
        public void getCategoryProduct()
        {
            try
            {
                conn = new SqlConnection(str);
                adapter = new SqlDataAdapter("Select * from TableProductCategory Order by Product_Category_ID", conn);
                dataset=new DataSet();

                adapter.Fill(dataset,"ProductCategory");

                comboBoxProductCategory.DataSource = dataset.Tables["ProductCategory"];
                comboBoxProductCategory.DisplayMember = "Product_Type_Name";
                comboBoxProductCategory.ValueMember = "Product_Category_ID";
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getProduct()
        {
            if (comboBoxProductCategory.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    conn = new SqlConnection(str);
                    adapter = new SqlDataAdapter("Select * from TableProduct where ProductTypeID =@Product_Category_ID", conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@Product_Category_ID", comboBoxProductCategory.SelectedValue);

                    dataset = new DataSet();
                    adapter.Fill(dataset, "Product");
                    comboBoxProduct.DataSource = dataset.Tables["Product"];
                    comboBoxProduct.DisplayMember = "ProductName";
                    comboBoxProduct.ValueMember = "ProductID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void getPrice()
        {
            if(comboBoxProduct.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    conn= new SqlConnection (str);
                    adapter = new SqlDataAdapter("Select ProductPrice from TableProduct where ProductID = @Product_Category_ID", conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@Product_Category_ID",comboBoxProduct.SelectedValue);

                    dataset = new DataSet();
                    adapter.Fill(dataset, "Product");

                    foreach(DataRow dr in dataset.Tables["Product"].Rows)
                    {
                        txtPrice.Text = dr["ProductPrice"].ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBoxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = "0";
            getProduct();
            TaxCharge();
           
            string catname=comboBoxProductCategory.Text;

            if(comboBoxProductCategory.Text != "System.Data.DataRowView")
            {
                conn = new SqlConnection (str);
                adapter = new SqlDataAdapter("Select * from TableProductGSTDetails Where Gst_Detail_Name = @Name",conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", catname);
                dataset = new DataSet();
                adapter.Fill(dataset, "GSTTable");

                foreach(DataRow dr in dataset.Tables["GSTTable"].Rows)
                {
                    txtCGST.Text = dr["CGST"].ToString();
                    txtSGST.Text = dr["SGST"].ToString();
                    txtIGST.Text = dr["IGST"].ToString();
                }
            }
        }
        Nationality nation;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Date
            DateTime SelectedDate = dateTimePicker1.Value;
            if (SelectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("");
            }

            //Full Name
            if (txtFullName.Text == "")
            {
                MessageBox.Show("fill the name");
            }

            //Nationality
            if(radiobtnIndian.Checked)
            {
                nation = Nationality.Indian;
            }
            else if(radiobtnNRI.Checked)
            {
                nation= Nationality.NRI;
            }

            //Contact No
            if(txtContactNo.Text == "")
            {
                MessageBox.Show("Fill the Conatact No");
            }         
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!= '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter only Number");
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = "0";
            txtTotalAmount.Text = "0";
            getPrice();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "")
            {
                double Price = Convert.ToDouble(txtPrice.Text);
                double Quantity = Convert.ToDouble(txtQuantity.Text);
                double TotalAmount = Price * Quantity;
                txtTotalAmount.Text = TotalAmount.ToString();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter only Number");
            }
        }
        public void TaxCharge()
        {
            if(comboBoxProductCategory.Text == "AC and Fridge")
            {
                double TotalPrice = Convert.ToDouble(txtTotalAmount.Text) * 0.14;
                txtNetAmount.Text = TotalPrice.ToString();
            }
        }
    }
}
