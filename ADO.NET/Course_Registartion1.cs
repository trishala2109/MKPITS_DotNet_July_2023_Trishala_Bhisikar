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
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            getNation();
            getState();
            getCity();

            if (radiobtnStudent.Checked)
            {
                txtTotalAmount.Text = "1000";
                txtFeesPaid.Text = "0";
                txtBalance.Text = "0";
            }
                
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

        public enum Category { Student,IT_Professional}
        public enum Gender { Male,Female,Other}

        Category category;
        Gender gender;

        float FessPaid = 0;
        float BalanceAmount = 0;
        public void calculation()
        {

            if(radiobtnStudent.Checked)
            {
                txtTotalAmount.Text = "1000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);

                 FessPaid = TotalAmount * 0.5f;

                if(Convert.ToSingle(txtFeesPaid.Text) < FessPaid )
                {
                    MessageBox.Show("Minimum 50% will Pay ");
                }
                else
                {
                     BalanceAmount = TotalAmount - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalance.Text = BalanceAmount.ToString();
                }
            }
            else if(radiobtnITProfession.Checked)
            {
                txtTotalAmount.Text = "3000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);

                FessPaid = TotalAmount * 0.8f;

                if (Convert.ToSingle(txtFeesPaid.Text) < FessPaid)
                {
                    MessageBox.Show("Minimum 80% will Pay ");
                }
                else
                {
                    BalanceAmount = TotalAmount - Convert.ToSingle(txtFeesPaid.Text);
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
                    gender = Gender.Female;
                }
                else if (radiobtnOthers.Checked)
                {
                    gender = Gender.Other;
                }
                MessageBox.Show("Gender " + gender);
            }

            DateTime selectedDate = dateTimePicker1.Value;
            if(selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("");
            }

            SaveCourseRegDetail(category,gender);
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

        public void SaveCourseRegDetail(Category c,Gender g)
        {
            try
            {
                string Result = "insert into TableCourseRegDetail values(@CategoryInd,@FullName,@GenderInd)";
                SqlCommand command = new SqlCommand(Result, conn);
                command.Parameters.AddWithValue("@CategoryInd", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName",txtFullName.Text);
                command.Parameters.AddWithValue("@GenderInd", Convert.ToInt32(g));

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Save the Record");
                InsertRegAddress();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertRegAddress()
        {
            conn.Open();

            string Result = "select max(CourseRegID) from TableCourseRegDetail";
            SqlCommand command = new SqlCommand(Result,conn);
            int mcid=Convert.ToInt32(command.ExecuteScalar());

            string res = "insert into TableRegAddress values (@CourseRegID,@NationID,@StateID,@CityID)";
            SqlCommand cmd = new SqlCommand(res,conn);
            cmd.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBoxNation.SelectedValue;
            cmd.Parameters.Add("@StateID",SqlDbType.Int).Value=comboBoxState.SelectedValue;
            cmd.Parameters.Add("@CityID",SqlDbType.Int).Value=comboBoxCity.SelectedValue;

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Store the RegAddress");
            InsertFessDetails();
        }

        public void InsertFessDetails()
        {
            conn.Open();

            string Result = "select max(CourseRegID) from TableCourseRegDetail";
            SqlCommand command = new SqlCommand(Result, conn);
            int mcid = Convert.ToInt32(command.ExecuteScalar());

            string res = "insert into TableFeeDetail values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd = new SqlCommand(res,conn);
            cmd.Parameters.Add("@CourseRegID",SqlDbType.Int).Value=(int)mcid;
            cmd.Parameters.Add("@TotalAmount", SqlDbType.Int).Value = txtTotalAmount.Text;
            cmd.Parameters.Add("@MinPer", SqlDbType.Int).Value = FessPaid;
            cmd.Parameters.Add("@PaidAmount",SqlDbType.Int).Value=txtFeesPaid.Text;
            cmd.Parameters.Add("@BalAmount", SqlDbType.Int).Value = txtBalance.Text;
            cmd.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Store Table Fees Details");
        }

        public void Clear()
        {
            getNation();
            getState();
            getCity();

            txtFullName.Clear();

            radiobtnStudent.Checked = true;
            radiobtnMale.Checked = true;

            comboBoxNation.Text = "";
            comboBoxState.Text = "";
            comboBoxCity.Text = "";

            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFeesPaid_Leave_1(object sender, EventArgs e)
        {
            calculation();
        }
    }
}
-------------------------------------------------

CREATE TABLE TableNation
                        (NationID INT PRIMARY KEY,
						 NationName VARCHAR(500));

INSERT INTO TableNation VALUES(1,'India'),
                              (2,'US'),
							  (3,'UK'),
							  (4,'Nepal'),
							  (5,'Shrilanka'),
							  (6,'Pakistan')
------------------------------------------

CREATE TABLE TableState 
                       (StateID INT PRIMARY KEY,
					    NationID INT,
						StateName VARCHAR(500),
						FOREIGN KEY (NationID)
						REFERENCES TableNation (NationID));

INSERT INTO TableState VALUES(101,1,'Maharshta'),
                             (102,1,'Andhra Pradesh'),
							 (103,1,'Madhya Pradesh')
INSERT INTO TableState VALUES(104,2,'Cliforniya'),
                             (105,2,'Montana'),
							 (106,3,'London'),
							 (107,3,'Paris'),
							 (108,4,'Karnali'),
							 (109,4,'Kochi'),
							 (110,5,'Colambo'),
							 (111,6,'Afganistan'),
							 (112,6,'Lahor')
-----------------------------------------------------

CREATE TABLE TableCity 
                     (CityID INT,
					  StateID INT,
					  CityName VARCHAR(500),
					  FOREIGN KEY (StateID)
					  REFERENCES TableState(StateID));

INSERT INTO TableCity VALUES(201,101,'Nagpur'),
                            (202,101,'Bhandara'),
							(203,103,'Bhopal'),
							(204,103,'Indore'),
							(205,104,'Adelando'),
							(206,104,'Albany'),
							(207,105,'Bozeman'),
							(208,105,'Havre')
INSERT INTO TableCity VALUES(209,106,'Hatfiled'),
                            (210,106,'BeetWooden'),
							(211,107,'Dijon'),
							(212,107,'Lyon'),
							(213,108,'Hemda'),
							(214,108,'Kheri'),
							(215,109,'Shimkoku'),
							(216,109,'Tosa'),
							(217,110,'Pittha'),
							(218,110,'Borelia'),
							(219,111,'Kabul'),
							(220,111,'Kosht'),
							(221,112,'Karachi'),
							(222,112,'Faislabad')
--------------------------------------------------------------

CREATE TABLE TableCourseRegDetail
                                 (CourseRegID INT PRIMARY KEY IDENTITY,
								  CategoryInd INT,
								  FullName VARCHAR(1500),
								  GenderInd INT);
---------------------------------------------------------

CREATE TABLE TableRegAddress 
                            (RegAddressID INT IDENTITY,
							 CourseRegID INT,
							 NationID INT,
							 StateID INT,
							 CityID INT,
							 FOREIGN KEY (CourseRegID) REFERENCES TableCourseRegDetail(CourseRegID),
							 FOREIGN KEY (NationID) REFERENCES TableNation(NationID));
	
-------------------------------------------

CREATE TABLE TableFeeDetail
                            (FeeID INT IDENTITY,
							 CourseRegID INT,
							 TotalAmount Decimal(10,2),
							 MinPer Decimal(10,2),
							 PaidAmount Decimal(10,2),
							 BalAmount Decimal(10,2),
							 PaidDate DateTime
							 FOREIGN KEY (CourseRegID) REFERENCES TableCourseRegDetail(CourseRegID));
----------------------------------------------

SELECT * FROM TableNation
SELECT * FROM TableState
SELECT * FROM TableCity
SELECT * FROM TableCourseRegDetail
SELECT * FROM TableRegAddress
SELECT * FROM TableFeeDetail

----------------------------------------------------

drop table TableFeeDetail
drop  table TableRegAddress
drop table TableCourseRegDetail
drop table TableNation
drop table TableState
drop table TableCity