using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_class_usin_this_and_user_defined
{
    class Customer
    {
        int customer_code;
        string customer_name;

        public void getData(int customer_code, string customer_name)
        {
            this.customer_code = customer_code;
            this.customer_name = customer_name;
        }

        public void displayData()
        {
            Console.WriteLine("Customer Code := " + customer_code);
            Console.WriteLine("Customer Name := " + customer_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Console.WriteLine("Enter Customer Code ");
            int cc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name ");
            string cn = Convert.ToString(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            cust.getData(cc, cn);
            cust.displayData();
            Console.ReadKey();
        }
    }
}
