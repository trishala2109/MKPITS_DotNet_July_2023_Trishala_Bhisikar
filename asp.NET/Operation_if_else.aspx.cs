using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Operation_if_else
{
    public partial class Operator_if_else : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2= Convert.ToInt32(TextBox2.Text);
            int result = 0;
            char operators = Convert.ToChar(TextBox3.Text);

            if(operators == '+')
            {
                result=num1 + num2;
            }
            else if(operators == '-')
            {
                result = num1 - num2;
            }
            else if(operators == '*')
            {
                result = num1 * num2;
            }
            else if(operators == '/')
            {
                result = num1 / num2;
            }
            Label1.Text = "Calculation :- " + result.ToString();
        }
    }
}