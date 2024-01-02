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
    }
}