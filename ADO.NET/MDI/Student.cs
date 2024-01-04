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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = ado;");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["stud"]);
                MessageBox.Show("upload data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Students ", conn);
            cb = new SqlCommandBuilder(da);

            //fill the table
            da.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
        }
    }
}
