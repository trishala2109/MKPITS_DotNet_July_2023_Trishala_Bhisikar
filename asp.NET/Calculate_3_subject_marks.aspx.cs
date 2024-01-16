using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_length_breath
{
    public partial class length_breath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
     protected void Button3_Click(object sender, EventArgs e)
{
    float physics = Convert.ToSingle(TextBox4.Text);
    float Chemistry = Convert.ToSingle(TextBox5.Text);
    float mathmaics= Convert.ToSingle(TextBox6.Text);

    float total = 0;
    float per = 0;
    string grade;

    total = Chemistry + physics + mathmaics;
    Label5.Text = "Total = " + total;

    per = total / 300 * 100;
    Label8.Text = "Percentagle = " + per;

    if(per >= 75)
    {
        grade = "A";
    }
    else if (per <= 75 && per >= 65)
    {
        grade = "B";
    }
    else if(per <= 65 && per >= 50)
    {
        grade = "C";
    }
    else
    {
        grade = "Fail";
    }
    Label10.Text = "Grade = " + grade;
}
    }
}