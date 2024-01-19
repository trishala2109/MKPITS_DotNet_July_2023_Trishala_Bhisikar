using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace greater_no
{
    public partial class greater_no : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32 (TextBox1.Text);
            int num2 = Convert.ToInt32 (TextBox2.Text);

            if(num1 > num2)
            {
                Label1.Text = "Number 1 is greater ";
            }
            else 
            {
                Label1.Text = "Number 2 is greter ";
            }
        }
    }
}