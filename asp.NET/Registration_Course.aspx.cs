using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Course
{
    public partial class Registration_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public enum Category { Student,IT_Professional}
        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            
            string category = null;
            if(RadiobtnStudents.Checked)
            {
                category = RadiobtnStudents.Text;
            }
            else if(RadiobtnIT_Professional.Checked)
            {
                category = RadiobtnIT_Professional.Text;
            }

            sb.Append("Category : " + category + "<br>");

            sb.Append("Candidate's Fullname : " + txtFullName.Text + "<br>");

            string gender = null;
            if(RadiobtnMale.Checked)
            {
                gender = RadiobtnMale.Text;
            }
            else if(RadiobtnFemale.Checked)
            {
                gender=RadiobtnFemale.Text;
            }
            else if(RadiobtnOthers.Checked)
            {
                gender = RadiobtnOthers.Text;
            }

            sb.Append("Gender : " + gender + "<br>");

            sb.Append("Country : " + DropDownListCountry.Text + "<br>");
            sb.Append("State : " + DropDownListState.Text + "<br>");
            sb.Append("City : " + DropDownListCity.Text + "<br>");

            sb.Append("Payment Date : " + txtPaymentDate.Text + "<br>");

            sb.Append("Total Amount :" + txtTotalAmount.Text + "<br>");

            sb.Append("Fess Paid Amount : " + txtFeesPaid.Text + "<br>");

            sb.Append("Balance Amount : " + txtBalanceAmount.Text + "<br>");
            
            Label1.Text = sb.ToString();
        }

        protected void DropDownListCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = DropDownListCountry.Text;
            DropDownListCity.Items.Clear();

            switch(country)
            {
                case "India":
                    DropDownListState.Items.Add ("Maharashta");
                    DropDownListState.Items.Add("Madhya Pradesh");
                    DropDownListState.Items.Add("Uttar Pradesh");
                    break;

                case "Pakistan":
                    DropDownListCountry.Items.Add("Afganistan");
                    DropDownListState.Items.Add("Kashmir");
                    break;

                case "Shrilanka":
                    DropDownListState.Items.Add("Kochi");
                    DropDownListState.Items.Add("Kotar");
                    break;

                case "USA":
                    DropDownListState.Items.Add("Paris");
                    DropDownListState.Items.Add("London");
                    DropDownListState.Items.Add("Californiya");
                    break;
            }
        }

        protected void DropDownListState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = DropDownListState.Text;
            DropDownListCity.Items.Clear();

            switch(state)
            {
                case "Maharashta":
                    DropDownListCity.Items.Add("Mumbai");
                    DropDownListCity.Items.Add("Pune");
                    DropDownListCity.Items.Add("Nagpur");
                    break;

                case "Madhya Pradesh":
                    DropDownListCity.Items.Add("Bhopal");
                    DropDownListCity.Items.Add("indore");
                    break;

                case "Uttar Prasesh":
                    DropDownListCity.Items.Add("Delhi");
                    DropDownListCity.Items.Add("Kanpur");
                    break;
            }
        }

        protected void RadiobtnStudents_CheckedChanged(object sender, EventArgs e)
        {
            if (RadiobtnStudents.Checked)
            {
                txtTotalAmount.Text = "1000";
                txtFeesPaid.Text = "0";
                txtBalanceAmount.Text = "0";
            }
        }

        protected void RadiobtnIT_Professional_CheckedChanged(object sender, EventArgs e)
        {
             if (RadiobtnIT_Professional.Checked)
             {
                txtTotalAmount.Text = "3000";
                txtFeesPaid.Text = "0";
                txtBalanceAmount.Text = "0";
            }
        }

        protected void txtFeesPaid_TextChanged(object sender, EventArgs e)
        {
            if (RadiobtnStudents.Checked)
            {
                txtTotalAmount.Text = "1000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);

                float FessPaid = TotalAmount * 0.5f;

                if (Convert.ToSingle(txtTotalAmount.Text) < FessPaid)
                {
                    Response.Write("Minimum 50% will Pay ");
                }
                else
                {
                    float BalanceAmount = TotalAmount - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalanceAmount.Text = BalanceAmount.ToString();
                }
            }
            else if (RadiobtnIT_Professional.Checked)
            {
                txtTotalAmount.Text = "3000";

                float TotalAmount = Convert.ToSingle(txtTotalAmount.Text);

                float FessPaid = TotalAmount * 0.8f;

                if (Convert.ToSingle(txtFeesPaid.Text) < FessPaid)
                {
                    Response.Write("Minimum 80% will Pay ");
                }
                else
                {
                    float BalanceAmount = TotalAmount - Convert.ToSingle(txtFeesPaid.Text);
                    txtBalanceAmount.Text = BalanceAmount.ToString();
                }
            }
        }
    }
}