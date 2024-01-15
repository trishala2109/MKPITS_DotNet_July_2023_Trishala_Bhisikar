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

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "Server = LAPTOP-9RQBBG2R\\SQLEXPRESS; Integrated Security = True; Database = Course Registration;";
        SqlConnection conn;
        DataSet dataset;
        SqlDataAdapter adapter;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetProductCategory();
        }

        public void GetProductCategory()
        {
            try
            {
                adapter = new SqlDataAdapter("Select * from TableProductCategory", conn);
                dataset = new DataSet();
                adapter.Fill(dataset, "Category");

                comboBoxProductCategory.DataSource = dataset.Tables["Category"];
                comboBoxProductCategory.DisplayMember = "Product_Type_Name";
                comboBoxProductCategory.ValueMember = " Product_Gst_ID";
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
