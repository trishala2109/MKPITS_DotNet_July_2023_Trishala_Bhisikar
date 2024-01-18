using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Account
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("Account no : " + Convert.ToInt32(TextBox1.Text) + "<br>");
            sb.Append("Account Holder Name :" + TextBox3.Text + "<br>");
            sb.Append("Balance is :" + amount + "<br>");

            Label1.Text = sb.ToString();
        }
        int amount = 0;
        int balance = 1000;

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(RadioButton1.Checked)
            {
                amount = Convert.ToInt32(TextBox2.Text);
                amount = amount + balance;
            }
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                amount = Convert.ToInt32(TextBox2.Text);
                amount = amount - balance;
            }
        }
    }
}