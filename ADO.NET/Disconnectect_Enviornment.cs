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

namespace Disconnect_Enviornment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = ado;");
        DataSet DS = new DataSet();
        SqlDataAdapter DA;
        SqlCommandBuilder CB = null;
        private void button1_Click(object sender, EventArgs e)
        {
            DA = new SqlDataAdapter("select * from Students",conn);
            CB = new SqlCommandBuilder(DA);

            //fill the data
            DA.Fill(DS, "student");
            dataGridView1.DataSource = DS.Tables["student"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DA.Update(DS.Tables["student"]);
                MessageBox.Show("Update the table");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
