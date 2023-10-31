using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_customer_class
{
    class Customer
    {
        public int customer_code;
        public string customer_name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object for customer class
            Customer cust = new Customer();
            cust.customer_code = 563;
            cust.customer_name = "Trish";
            Console.WriteLine("Customer code :- " +cust.customer_code);
            Console.WriteLine("Customer name :- " + cust.customer_name);
            Console.ReadKey();
        }
    }
}
