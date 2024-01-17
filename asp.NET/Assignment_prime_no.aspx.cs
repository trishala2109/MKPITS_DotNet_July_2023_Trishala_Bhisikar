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
            int counter = 0;

            for (int i = 0; i < num; i++)
            {
                if (num % 2 == 0)
                {
                    counter++;
                }
            }
            if(counter == 0)
            {
                Label1.Text = "it is prime";
            }
            else
            {
                Label1.Text = "it is not prime";
            }
        }
    }
}