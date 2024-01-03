CREATE TABLE Students (RollNo INT PRIMARY KEY,
                       StudentName VARCHAR(100),
					   Gender VARCHAR(100),
					   Hobby VARCHAR(100),
					   City VARCHAR(100),
					   DOB VARCHAR(100))
SELECT * FROM Students
--------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_form
{
    class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }
        public string City { get; set; }
        public string DOB { get; set; }
        public Student(int RollNo,string StudentName,string Gender,string Hobby,string City,string DOB)
        {
            this.RollNo = RollNo;
            this.StudentName= StudentName;
            this.Gender = Gender;
            this.Hobby = Hobby;
            this.City = City;
            this.DOB = DOB;
        }
    }
    class StudentForm
    {
        string str = "server = LAPTOP-9RQBBG2R\\SQLEXPRESS; integrated security = true; database = ado;";

        //creating method insert the student details

        public string InsertStudentDetails(int RollNo,string StudentName,string Gender,string Hobby, string City, string DOB)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string result = "insert into Students values (@RollNo,@StudentName,@Gender,@Hobby,@City,@DOB)";
                using (SqlCommand cmd = new SqlCommand(result, conn))
                {
                    cmd.Parameters.AddWithValue("@RollNo",RollNo);
                    cmd.Parameters.AddWithValue("@StudentName", StudentName);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Hobby", Hobby);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Record Insert Sucesfully !");
                    return "";
                }
            }
        }

        public string UpdateStudentDetails(int RollNo,string StudentName,string Gender,string Hobby,string City,string DOB)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string result = "update Students set StudentName=@StudentName,Gender=@Gender,Hobby=@Hobby,City=@City,DOB=@DOB Where RollNo=@RollNo";
                using (SqlCommand command = new SqlCommand(result,conn))
                {
                    command.Parameters.AddWithValue("@StudentName", StudentName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Hobby", Hobby);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@DOB",DOB);
                    command.Parameters.AddWithValue("@RollNo", RollNo);

                    command.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Update data Succesfully");
                    return "";
                }
            }
        }

        public string DeleteStudentDetails(int RollNo,string StudentName)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open ();
                string result = "delete from Students Where RollNo =@RollNo or StudentName = @StudentName";
                using (SqlCommand command = new SqlCommand(result,conn))
                {
                    command.Parameters.AddWithValue("@RollNo",RollNo);
                    command.Parameters.AddWithValue("@StudentName", StudentName);

                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Delete Data Successfully !");

                    return "";
                }
            }
        }

        public List<Student> SearchStudentDetails(int RollNo)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string result = "select * from Students Where RollNo = @RollNo";

                using (SqlCommand command = new SqlCommand(result,conn))
                {
                    command.Parameters.AddWithValue("@RollNo",RollNo);

                    SqlDataReader dr;
                    dr = command.ExecuteReader();

                    List<Student> list = new List<Student>();
                    while (dr.Read())
                    {
                        list.Add(new Student(Convert.ToInt32(dr["RollNo"].ToString()), dr["StudentName"].ToString(), dr["Gender"].ToString(), dr["Hobby"].ToString(), dr["City"].ToString(), dr["DOB"].ToString()));
                        
                    }

                    dr.Close();

                    return list;

                    conn.Close();
                }
            }
        }
    }
}
-------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Student_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedItem = "";
            dateTimePicker1.Value= DateTime.Now;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StudentForm stud = new StudentForm();

            string Result = stud.DeleteStudentDetails(Convert.ToInt32(textBox1.Text), textBox2.Text);
            ClearText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm stud = new StudentForm();

            string gender = null;
            if(radioButton1.Checked)
            {
                gender = "Male";
            }
            else if(radioButton2.Checked)
            {
                gender = "Female";
            }

            string hobby = null;
            if(checkBox1.Checked)
            {
                hobby = "Reading";
            }
            if(checkBox2.Checked)
            {
                if (hobby != null)
                {
                    hobby = hobby + "" + "Music";
                }
                else
                {
                    hobby = "Music";
                }
            }

            string Result = stud.InsertStudentDetails(Convert.ToInt32(textBox1.Text), textBox2.Text,gender,hobby,comboBox1.Text,dateTimePicker1.Value.ToShortDateString());
            ClearText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentForm stud = new StudentForm();

            string gender = null;

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }

            string hobby = null;
            if (checkBox1.Checked)
            {
                hobby = "Reading";
            }
            if (checkBox2.Checked)
            {
                if (hobby != null)
                {
                    hobby = hobby + "" + "Music";
                }
                else
                {
                    hobby = "Music";
                }
            }

            string Result = stud.UpdateStudentDetails(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, hobby, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            ClearText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Student> li = new List<Student>();

            StudentForm stud = new StudentForm();
            //RollNo
            li = stud.SearchStudentDetails(Convert.ToInt32(textBox1.Text));

            //StudentName
            textBox2.Text = li[0].StudentName;

            //Gender
            string Gender = li[0].Gender;

            if (Gender == "Male")
            {
                radioButton1.Checked = true;
               
            }
            if (Gender == "Female")
            {
               radioButton2.Checked = true;
            }

            //hobby
            string Hobby = li[0].Hobby;

            if (Hobby == "Reading" && Hobby == "Music")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
            if (Hobby == "Reading")
            {
                checkBox1.Checked = true;
            }
            if (Hobby == "Music")
            {
                checkBox2.Checked = true;
            }

            //City
            comboBox1.Text = li[0].City;

            //DOB
            dateTimePicker1.Text = li[0].DOB;
        }
    }
}
