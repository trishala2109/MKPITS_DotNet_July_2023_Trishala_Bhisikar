using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_machintest
{
    class Account
    {
        public string AccountNo { get; }
        public decimal Balance { get; set; }
        public Account(string AccountNo,decimal Balance)
        {
            this.AccountNo = AccountNo;
            this.Balance = Balance;
        }
        public void Deposite(int Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine("Deposite amount of and remaining Balance is : " + Balance);
        }
        public bool Withdrwal(int Amount)
        {
            if (Balance - Amount <= 0)
            {
                Balance = Balance - Amount;
               Console.WriteLine("Withdrwal Amounut and remainig Balance is : " + Balance);
                return true;
                     
            }
            else
            {
                Console.WriteLine("Your Amount is not Sufficient to withdrwal You will be not Withdrwal the amount");
                return false;
            }          
        }
    }
    class Customer
    {
        public string Name { get; set; }

        List<Account> act = new List<Account>();
        public Customer(string Name)
        {
            this.Name = Name;
        }
        public void AddAccount(Account account)
        {
            act.Add(account);
        }

        public decimal GetTotalaBalance()
        {
            decimal TotalBalance = 0;
            foreach(Account account in act)
            {
                TotalBalance += account.Balance;
            }
            return TotalBalance;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Customer Name : " + Name);
            foreach(Account account in act)
            {
                Console.WriteLine("Account No : " + account.AccountNo + "\n" + "Balance : " + account.Balance);
            }
            Console.WriteLine("Total Balance is : " + GetTotalaBalance());
        }
    }
    class Bank
    {
        List<Customer> cust = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            cust.Add(customer);
        }
    }
    internal class Program
    {
        static void Main()
        {
            //create bank objcet
            Bank myBank = new Bank();

            //create customer object
            Customer cust1 = new Customer("c1");
            Customer cust2 = new Customer("c2");

            //create account object
            Account act1 = new Account("A1110", 1000);
            Account act2 = new Account("A2110",1500);
            Account act3 = new Account("A3110", 2500);

            //
            cust1.AddAccount(act1);
            cust1.AddAccount(act2);
            cust2.AddAccount(act3);

            //add customer to the bank
            myBank.AddCustomer(cust1);
            myBank.AddCustomer(cust2);

            //perform transaction
            act1.Deposite(200);
            act2.Withdrwal(300);
            act3.Withdrwal(200);

            //display
            cust1.DisplayAccountDetails();
            cust2.DisplayAccountDetails();
            
            Console.ReadLine();
        }
    }
}
