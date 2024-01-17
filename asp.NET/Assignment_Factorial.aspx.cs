using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace factorial
{
    public partial class factorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int i;
            int fact = 1;

            for(i = num; i > 0; i--)
            {
                fact = fact * i;
            }
            Label1.Text = "Fcatorial = " + fact;
        }
    }
}