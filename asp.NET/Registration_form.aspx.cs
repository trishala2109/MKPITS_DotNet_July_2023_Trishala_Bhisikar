using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_form
{
    public partial class Registration_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb= new System.Text.StringBuilder();

            //Username, Password, Address
           
            sb.Append("Username :- " + TextBox1.Text + "<br>");
            sb.Append("Password :- " + TextBox2.Text + "<br>");
            sb.Append("Address :- " + TextBox3.Text + "<br>");

            //Gender
            string gender = null;
            if(RadioButton1.Checked)
            {
                gender = RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
            }
            else if(RadioButton3.Checked)
            {
                gender = RadioButton3.Text;
            }
            sb.Append("Gender :- " + gender + "<br>");

            //Hobbys
            string hobby = null;
            if(CheckBox1.Checked) 
            {
                hobby = hobby + " " + CheckBox1.Text;
            }
            if (CheckBox1.Checked)
            {
                hobby = hobby + " " + CheckBox2.Text;
            }
            if (CheckBox1.Checked)
            {
                hobby = hobby + " " + CheckBox3.Text;
            }
            sb.Append("Hobby :- " + hobby + "<br>");
           
            //Country
            sb.Append("Country :- " + DropDownList1.Text + "<br>");
            sb.Append("City :- " + DropDownList2.Text + "<br>");

            //Courses
            string course = null;
            foreach(ListItem li in ListBox1.Items)
            {
                if(li.Selected)
                {
                    course = course + li.Value + "<br>";
                }
            }

            sb.Append("Courses :- " + course + "<br>");

            Label1.Text = sb.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = DropDownList1.Text;
            DropDownList2.Items.Clear();

            switch(country)
            {
                case "India":
                    DropDownList2.Items.Add("Mumbai");
                    DropDownList2.Items.Add("Delhi");
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Pune");
                    break;

                case "USA":
                    DropDownList2.Items.Add("Californiya");
                    DropDownList2.Items.Add("London");
                    DropDownList2.Items.Add("Paris");
                    DropDownList2.Items.Add("DisneyLand");
                    break;

                case "Shrilanka":
                    DropDownList2.Items.Add("Kochi");
                    DropDownList2.Items.Add("Katmandu");
                    break;

                case "Pakistan":
                    DropDownList2.Items.Add("Afganistan");
                    DropDownList2.Items.Add("Lahor");
                    DropDownList2.Items.Add("Usmanabad");
                    DropDownList2.Items.Add("Gajiyabad");
                    break;
            }
        }
    }
}