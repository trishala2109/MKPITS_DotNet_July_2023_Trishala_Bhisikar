using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orders
{
    public partial class orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("Order No. :" + Convert.ToInt32(TextBox1.Text) + "<br>");
            sb.Append("Customer Name : " + TextBox2.Text + "<br>");
            sb.Append("Order Date : " + TextBox3.Text + "<br>");
            sb.Append("Product : " + DropDownList1.Text + "<br>");
            sb.Append("Price : " + Convert.ToInt32(TextBox4.Text) + "<br>");

           
            sb.Append("Quantity : " + Convert.ToInt32(TextBox5.Text) + "<br>");

            int totalAmount = Convert.ToInt32(TextBox4.Text) * Convert.ToInt32(TextBox5.Text);

            sb.Append("Total Amount : " + totalAmount + "<br>");
            Label1.Text = sb.ToString();
        }
        int price = 0;
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}