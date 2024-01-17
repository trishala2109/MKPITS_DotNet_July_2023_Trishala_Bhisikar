using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string designation = TextBox2.Text;
            float salary = Convert.ToSingle(TextBox3.Text);

            float HRA = 0;
            float DA = 0;
            float TotalSalary = 0;
            
            // using Switch 
            switch(designation)
            {
                case "Manager":
                    HRA = salary * 0.45f;
                    DA = salary * 0.35f;
                    TotalSalary = HRA + DA + salary;
                    break;

                case "Peon":
                    HRA = salary * 0.45f;
                    DA = salary * 0.35f;
                    TotalSalary = HRA + DA + salary;
                    break;

                default:
                    Response.Write("invalid Designation ");
                    break;
            }
            Label1.Text = "HRA = " + HRA;
            Label2.Text = "DA = " + DA;
            Label3.Text = "Total Salary = " + TotalSalary;

        }
    }
}