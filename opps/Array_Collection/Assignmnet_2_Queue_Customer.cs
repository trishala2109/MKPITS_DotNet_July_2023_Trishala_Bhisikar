using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_2_Queue_Customer
{
    class Customer
    {
        public int CustomerID;
        public string Name;
        public string Email;
        public int MobileNo;
        public Customer(int CustomerID,string Name, string Email,int MobileNo)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Email = Email;
            this.MobileNo = MobileNo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(6321, "Amit", "amit@gmail.com", 693214587);
            Customer c2 = new Customer(6322, "Sumit", "sumit@gmail.com", 69634587);
            Customer c3 = new Customer(6323, "Pooja", "pooja@gmail.com", 752314587);
            Customer c4 = new Customer(6324, "Rishi", "rishi@gmail.com", 996214587);

            Queue q = new Queue();
            q.Enqueue(c1);
            q.Enqueue(c2);
            q.Enqueue(c3);
            q.Enqueue(c4);

            Console.WriteLine("-------Before Dequeue-------");
            Console.WriteLine();
            foreach (Customer c in q)
            {
                Console.WriteLine("Customer ID : " + c.CustomerID);
                Console.WriteLine("Customer Name : " + c.Name);
                Console.WriteLine("Email : " + c.Email);
                Console.WriteLine("Mobile No. : " + c.MobileNo);
                Console.WriteLine();
            }

            q.Dequeue();
            Console.WriteLine("-------After Dequeue-------");
            Console.WriteLine();
            foreach (Customer c in q)
            {
                Console.WriteLine("Customer ID : " + c.CustomerID);
                Console.WriteLine("Customer Name : " + c.Name);
                Console.WriteLine("Email : " + c.Email);
                Console.WriteLine("Mobile No. : " + c.MobileNo);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
