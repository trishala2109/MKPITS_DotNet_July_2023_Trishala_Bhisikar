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

        public enum Nationality { Indian, NRI }
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
                dataset = new DataSet();

                adapter.Fill(dataset, "ProductCategory");

                comboBoxProductCategory.DataSource = dataset.Tables["ProductCategory"];
                comboBoxProductCategory.DisplayMember = "Product_Type_Name";
                comboBoxProductCategory.ValueMember = "Product_Category_ID";
            }
            catch (SqlException ex)
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
            if (comboBoxProduct.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    conn = new SqlConnection(str);
                    adapter = new SqlDataAdapter("Select ProductPrice from TableProduct where ProductID = @Product_Category_ID", conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@Product_Category_ID", comboBoxProduct.SelectedValue);

                    dataset = new DataSet();
                    adapter.Fill(dataset, "Product");

                    foreach (DataRow dr in dataset.Tables["Product"].Rows)
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

            string catname = comboBoxProductCategory.Text;

            if (comboBoxProductCategory.Text != "System.Data.DataRowView")
            {
                conn = new SqlConnection(str);
                adapter = new SqlDataAdapter("Select * from TableProductGSTDetails Where Gst_Detail_Name = @Name", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", catname);
                dataset = new DataSet();
                adapter.Fill(dataset, "GSTTable");

                foreach (DataRow dr in dataset.Tables["GSTTable"].Rows)
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

            //Contact No
            if (txtContactNo.Text == "")
            {
                MessageBox.Show("Fill the Conatact No");
            }

            //DATA INSERT 
            InsertData();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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
        double TotalCGST = 0;
        double TotalSGST = 0;
        double TotalIGST = 0;
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                double Price = Convert.ToDouble(txtPrice.Text);
                double Quantity = Convert.ToDouble(txtQuantity.Text);
                double TotalAmount = Price * Quantity;
                txtTotalAmount.Text = TotalAmount.ToString();

                double TotalPrecentCGST = Convert.ToDouble(txtTotalAmount.Text);
                TotalCGST = TotalAmount * (TotalPrecentCGST / 100);
                txtCGSTAmount.Text = TotalCGST.ToString();

                double TotalPrecentSGST = Convert.ToDouble(txtTotalAmount.Text);
                TotalSGST = TotalAmount * (TotalPrecentSGST / 100);
                txtSGSTAmount.Text = TotalCGST.ToString();

                double TotalPrecentIGST = Convert.ToDouble(txtTotalAmount.Text);
                TotalIGST = TotalAmount * (TotalPrecentIGST / 100);
                txtIGSTAmount.Text = TotalCGST.ToString();

                if(nation.ToString() == "Indian")
                {
                    double NetAmount = Convert.ToDouble(txtTotalAmount.Text) + Convert.ToDouble(txtCGSTAmount.Text) + Convert.ToDouble(txtSGSTAmount.Text);
                    txtNetAmount.Text = NetAmount.ToString();
                }
                else if (nation.ToString() == "NRI")
                {
                    double NetAmount = Convert.ToDouble(txtTotalAmount.Text) + Convert.ToDouble(txtIGSTAmount.Text);
                    txtNetAmount.Text = NetAmount.ToString();
                }
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnIndian_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnIndian.Checked)
            {
                nation = Nationality.Indian;
                txtPrice.Text = "0";
                txtQuantity.Text = "0";
                txtTotalAmount.Text = "0";
                txtNetAmount.Text="0";
                txtCGSTAmount.Text="0";
                txtSGSTAmount.Text="0";
                txtIGSTAmount.Text = "0";
            }
        }

        private void radiobtnNRI_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnNRI.Checked)
            {
                nation= Nationality.NRI;
                txtPrice.Text = "0";
                txtQuantity.Text = "0";
                txtTotalAmount.Text = "0";
                txtNetAmount.Text = "0";
                txtCGSTAmount.Text = "0";
                txtSGSTAmount.Text = "0";
                txtIGSTAmount.Text = "0";
            }
        }

        public void InsertData()
        {
            conn = new SqlConnection(str);

            conn.Open();

            string Result = "insert into TableInvoiceDetails values (@Customer_Name,@Customer_Contact, @Product_Category_ID, @Product_ID, @Residential_Type_ID, @Invoice_Date, @Quantity, @Price, @CGST, @SGST, @IGST, @CGST_Value, @SGST_Value, @IGST_Value, @TotalAmount)";
            SqlCommand command = new SqlCommand(Result, conn);

            command.Parameters.Add("@Customer_Name",SqlDbType.VarChar).Value = txtFullName.Text;
            command.Parameters.Add("@Customer_Contact",SqlDbType.VarChar).Value = txtContactNo.Text;
            command.Parameters.Add("@Product_Category_ID", SqlDbType.Int).Value = comboBoxProductCategory.SelectedValue;
            command.Parameters.Add("@Product_ID", SqlDbType.Int).Value = comboBoxProduct.SelectedValue;
            command.Parameters.Add("@Residential_Type_ID", SqlDbType.Int).Value = 1001;
            command.Parameters.Add("@Invoice_Date", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            command.Parameters.Add("@Quantity",SqlDbType.Decimal).Value = txtQuantity.Text;
            command.Parameters.Add("@Price",SqlDbType.Decimal).Value = txtPrice.Text;
            command.Parameters.Add("@CGST",SqlDbType.Decimal).Value = txtCGST.Text;
            command.Parameters.Add("@SGST", SqlDbType.Decimal).Value = txtSGST.Text;
            command.Parameters.Add("@IGST", SqlDbType.Decimal).Value = txtIGST.Text;
            command.Parameters.Add("@CGST_Value",SqlDbType.Decimal).Value = txtCGSTAmount.Text;
            command.Parameters.Add("@SGST_Value", SqlDbType.Decimal).Value = txtSGSTAmount.Text;
            command.Parameters.Add("@IGST_Value", SqlDbType.Decimal).Value = txtIGSTAmount.Text;
            command.Parameters.Add("@TotalAmount",SqlDbType.Decimal).Value = txtTotalAmount.Text;

            command.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data is Insert");
        }
        
        public void Clear()
        {
            txtFullName.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtQuantity.Text = "0";
            txtPrice.Text = "0";
            txtCGST.Text = "0";
            txtSGST.Text = "0";
            txtIGST.Text = "0";
            txtTotalAmount.Text = "0";
            txtNetAmount.Text = "0";
            txtCGSTAmount.Text = "0";
            txtSGSTAmount.Text = "0";
            txtIGSTAmount.Text = "0";
            comboBoxProduct.Text = "Select";
            comboBoxProductCategory.Text = "Select";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
