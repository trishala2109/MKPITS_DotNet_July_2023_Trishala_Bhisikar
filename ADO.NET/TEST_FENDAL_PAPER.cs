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
using System.Data.Common;
using System.Collections.ObjectModel;

namespace TEST_FENDAL_PAPER
{
    public partial class frmCourseRegistration : Form
    {
        public frmCourseRegistration()
        {
            InitializeComponent();
        }
        string str = "Server = LAPTOP-9RQBBG2R\\SQLEXPRESS; Integrated Security = True; Database = Registration Course;";
        SqlConnection conn;
        DataSet dataset;
        SqlDataAdapter adapter;

        public enum Category { Student, IT_Profession}
        public  enum Gender { Male, Female , Others}
        private void frmCourseRegistration_Load(object sender, EventArgs e)
        {
            getNation();
            getState();
            getCity();
        }
        //Address Details
        public void getNation()
        {
            try
            {
                conn = new SqlConnection(str);
                adapter = new SqlDataAdapter("Select * from TableNation Order by NationID", conn);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "Nation");

                comboBoxNation.DataSource = dataSet.Tables["Nation"];
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
            if(comboBoxNation.SelectedValue.ToString() != "System.Data.DataRowView")       
            {
                
                try
                {
                    conn = new SqlConnection(str);
                    adapter = new SqlDataAdapter("Select * from TableState where NationID = @NationID", conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@NationID", comboBoxNation.SelectedValue);


                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "State");

                    comboBoxState.DataSource = dataSet.Tables["State"];
                    comboBoxState.DisplayMember = "StateName";
                    comboBoxState.ValueMember = "StateID";
                }
                catch(SqlException ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void getCity()
        {
            if(comboBoxState.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    conn=new SqlConnection(str);
                    adapter = new SqlDataAdapter("select * from TableCity where StateID = @StateID", conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@StateID", comboBoxState.SelectedValue);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "City");
                    comboBoxCity.DataSource = dataSet.Tables["City"];
                    comboBoxCity.DisplayMember = "CityName";
                    comboBoxCity.ValueMember = "CityID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
          
        private void comboBoxNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCity();
        }

        //Student Details
        Category category;
        Gender gender;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Fill the Candidate's Full Name");
            }
            else
            {
                //Category
                if (radibtnStudent.Checked)
                {
                    category = Category.Student;
                }
                else if(radiobtnITProfession.Checked)
                {
                    category = Category.IT_Profession;
                }

                //Gender
                if(radiobtnMale.Checked)
                {
                    gender = Gender.Male;
                }
                else if(radiobtnFemale.Checked)
                {
                    gender = Gender.Female;
                }
                else if(radiobtnOthers.Checked)
                {
                    gender = Gender.Others;
                }
            }

            DateTime SelectedDate = dateTimePicker1.Value;
            if(SelectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("");
            }

            SaveCourseRegDetails(category, gender);
        }
        //Fees Details
        float FeesPaid = 0;
        float BalanaceAmount = 0;
        public void FeesCalculations()
        {
            if(radibtnStudent.Checked)
            {
                txtTotalAmount.Text = "1000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);
                float FeesPaid = 0.5f * TotalAmount;

                if(Convert.ToSingle(txtFeesPaid.Text) < FeesPaid)
                {
                    MessageBox.Show("Minimun 50% Fees Paid");
                }
                else
                {
                    float BalanceAmount = TotalAmount - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalanceAmount.Text = BalanceAmount.ToString();
                }
            }
            else if(radiobtnITProfession.Checked)
            {
                txtTotalAmount.Text = "3000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);
                float FeesPaid = 0.5f * TotalAmount;

                if (Convert.ToSingle(txtFeesPaid.Text) < FeesPaid)
                {
                    MessageBox.Show("Minimun 80% Fees Paid");
                }
                else
                {
                    float BalanceAmount = TotalAmount - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalanceAmount.Text = BalanceAmount.ToString();
                }
            }
        }
        
        public void SaveCourseRegDetails(Category c,Gender g)
        {
            try
            {  
                string result = "insert into TableCourseRegDetail values(@CategoryInd,@FullName,@GenderInd)";
                SqlCommand command = new SqlCommand(result, conn);
                command.Parameters.AddWithValue("@CategoryInd", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", txtFullName.Text);
                command.Parameters.AddWithValue("@GenderInd", Convert.ToInt32(g));

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Save the Course Details");
                InsertRegAddress();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertRegAddress()
        {
            try
            {
                conn.Open();

                string Result = "select  max(CourseRegID) from TableCourseRegDetail";
                SqlCommand cmd = new SqlCommand(Result, conn);
                int mcid = Convert.ToInt32(cmd.ExecuteScalar());

                string res = "insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
                SqlCommand command = new SqlCommand(res, conn);
                command.Parameters.Add("@CourseRegID",SqlDbType.Int).Value = mcid;
                command.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBoxNation.SelectedValue;
                command.Parameters.Add("@StateID",SqlDbType.Int).Value=comboBoxState.SelectedValue;
                command.Parameters.Add("@CityID",SqlDbType.Int).Value=comboBoxCity.SelectedValue;

                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Save Address Details");
                FeesDetils();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FeesDetils()
        {
            try
            {
                conn.Open();

                string Result = "select  max(CourseRegID) from TableCourseRegDetail";
                SqlCommand cmd = new SqlCommand(Result, conn);
                int mcid = Convert.ToInt32(cmd.ExecuteScalar());

                string res = "insert into TableFeeDetail values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
                SqlCommand command=new SqlCommand(res, conn);
                command.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
                command.Parameters.Add("@TotalAmount", SqlDbType.Int).Value = txtTotalAmount.Text;
                command.Parameters.Add("@MinPer", SqlDbType.Int).Value = FeesPaid;
                command.Parameters.Add("@PaidAmount",SqlDbType.Int).Value=txtFeesPaid.Text;
                command.Parameters.Add("@BalAmount", SqlDbType.Int).Value = txtBalanceAmount.Text;
                command.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;

                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Save the Fees Details");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radibtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if(radibtnStudent.Checked)
            {
                category=Category.Student;
                txtTotalAmount.Text = "1000";
                txtFeesPaid.Text = "0";
                txtBalanceAmount.Text = "0";
            }
        }

        private void radiobtnITProfession_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnITProfession.Checked)
            {
                category = Category.IT_Profession;
                txtTotalAmount.Text = "3000";
                txtFeesPaid.Text = "0";
                txtBalanceAmount.Text = "0";
            }
        }

        private void txtFeesPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLeave(object sender, EventArgs e)
        {
            FeesCalculations();
        }
    }
}
