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
using System.Runtime.Remoting.Contexts;

namespace Course_Registartion
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
            getNation();
        }

        private void comboBoxNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCity();
        }
        public void getNation()
        {
            try
            {
                conn = new SqlConnection(str);
                adapter = new SqlDataAdapter("select * from TableNation Order by NationID", conn);
                dataset = new DataSet();
                adapter.Fill(dataset, "TableNation");
                comboBoxNation.DataSource = dataset.Tables["TableNation"];
                comboBoxNation.DisplayMember = "NationName";
                comboBoxNation.ValueMember = "NationID";

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getState()
        {
            if (comboBoxNation.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    conn = new SqlConnection(str);
                    adapter = new SqlDataAdapter("select * from TableState Where NationID = @NationID", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@NationID", comboBoxNation.SelectedValue);
                    dataset = new DataSet();
                    dataset.Clear();
                    adapter.Fill(dataset, "TableState");
                    comboBoxState.DataSource = dataset.Tables["TableState"];
                    comboBoxState.DisplayMember = "StateName";
                    comboBoxState.ValueMember = "StateID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void getCity()
        {
            if (comboBoxState.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    conn = new SqlConnection(str);
                    adapter = new SqlDataAdapter("select * from TableCity  Where StateID = @StateID", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StateID", comboBoxState.SelectedValue);
                    dataset = new DataSet();
                    dataset.Clear();
                    adapter.Fill(dataset, "TableCity");
                    comboBoxCity.DataSource = dataset.Tables["TableCity"];
                    comboBoxCity.DisplayMember = "CityName";
                    comboBoxCity.ValueMember = "CityID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        enum Category { Student,IT_Professional}
        enum Gender { Male,Female,Other}

        Category category;
        Gender gender;
        public void calculation()
        {
            if(Category.Student.ToString() == "Student")
            {
                txtTotalAmount.Text = "1000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);
                float FessPaid = TotalAmount * 0.5f;
                float Amount = Convert.ToSingle(txtFeesPaid.Text);

                if(Amount < FessPaid)
                {
                    MessageBox.Show("Minimum 50% will Pay ");
                }
                else
                {
                    float BalanceAmount = TotalAmount - Amount;
                    txtBalance.Text = BalanceAmount.ToString();
                }
            }
            else if(Category.IT_Professional.ToString() == "IT Professional")
            {
                txtTotalAmount.Text = "3000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);
                float FessPaid = TotalAmount * 0.8f;
                float Amount = Convert.ToSingle(txtFeesPaid.Text);

                if (Amount < FessPaid)
                {
                    MessageBox.Show("Minimum 80% will Pay ");
                }
                else
                {
                    float BalanceAmount = TotalAmount - Amount;
                    txtBalance.Text = BalanceAmount.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Fill the name");
            }
            else
            {
                //Category
                if (radiobtnStudent.Checked)
                {
                    category = Category.Student;
                }
                else if (radiobtnITProfession.Checked)
                {
                    category = Category.IT_Professional;
                }
                MessageBox.Show("Category "+ category);
                //Gender
                if (radiobtnMale.Checked)
                {
                    gender = Gender.Male;
                }
                else if (radiobtnFemale.Checked)
                {
                    gender = Gender.Other;
                }
                else if (radiobtnOthers.Checked)
                {
                    gender = Gender.Other;
                }
                MessageBox.Show("Gender " + gender);
            }
        }

        private void radiobtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnStudent.Checked)
            {
                category= Category.Student;
                txtTotalAmount.Text = "1000";
                txtFeesPaid.Text = "0";
                txtBalance.Text = "0";
            }
        }

        private void txtFeesPaid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFeesPaid_Leave(object sender, EventArgs e)
        {
            calculation();
        }

        private void radiobtnITProfession_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnITProfession.Checked)
            {
                category = Category.IT_Professional;
                txtTotalAmount.Text = "3000";
                txtFeesPaid.Text = "0";
                txtBalance.Text = "0";
            }
        }
    }
}
