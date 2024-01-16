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

        protected void Button2_Click(object sender, EventArgs e)
        {
            float radius = Convert.ToSingle(TextBox3.Text);
            float area_of_Circle = 0;
            float circumfrance = 0;

            area_of_Circle = 3.14f * radius * radius;
            Label3.Text = "Area of Circle = " + area_of_Circle;

            circumfrance = 2 * 3.14f * radius;
            Label4.Text = "Circumfrance of circle = " + circumfrance;
        }
    }
}