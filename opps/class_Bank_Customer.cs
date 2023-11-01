using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Bank_Customer
{
    class BankCustomer
    {
        public string  CustomerName { get; set; }
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public int Deposite { get; set; }
        public int Withdrwal { get; set; }

        public void getData(string CustomerName,int AccountNumber,int Balance,int Deposite,int Withdrwal)
        {
            this.CustomerName = CustomerName;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.Deposite = Deposite;
            this.Withdrwal = Withdrwal;
        }

        public void display()
        {
            Console.WriteLine("-----------------------------Transaction---------------------------");
            Console.WriteLine("Customer Name :- " + CustomerName);
            Console.WriteLine("Account Number :- " + AccountNumber);
            Console.WriteLine("Deposite Amount :- " + Deposite);
            Console.WriteLine("Withdrwal Amount :- " + Withdrwal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankCustomer bank = new BankCustomer();

            string Name;
            int balance=100,amount;
            int Number;

            Console.Write("Enter Customer Name :-");
            Name = Console.ReadLine();
            Console.Write("Enter Account No. :-");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount :- ");
            amount = Convert.ToInt32(Console.ReadLine());

            int deposite=amount + balance;
            int witdrwal = amount - balance;

            bank.getData(Name, Number,balance, deposite, witdrwal);
            bank.display();

            Console.ReadKey();
            

        }
    }
}
