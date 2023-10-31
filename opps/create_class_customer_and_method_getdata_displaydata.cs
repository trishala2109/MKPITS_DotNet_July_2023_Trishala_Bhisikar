using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_customer_and_method_getdata_displaydata
{
    class Customer
    {
        int customer_code;
        string customer_name;

        public void getData(int cc, string cn)
        {
            customer_code = cc;
            customer_name = cn;
        }
        public void displayData()
        {
            Console.WriteLine("Customer Code :- " + customer_code);
            Console.WriteLine("Customer Name :- " + customer_name);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Customer cust = new Customer();
                cust.getData(223, "Trish");
                cust.displayData();
                Console.ReadKey();
            }
        }
    }
}
