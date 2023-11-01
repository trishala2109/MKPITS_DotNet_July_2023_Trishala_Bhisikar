using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_bank_account
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }

        public void display()
        {
            Console.WriteLine("Account Number :- " + AccountNumber);
            Console.WriteLine("Account Holder Name :- " + AccountHolderName);
            Console.WriteLine("Account Balance Amount :- " + Balance);
            Console.WriteLine("------------------------------------");
        }

        public void Transfer(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;
        }
        public void ShowBalance()
        {
            Console.WriteLine("The Account No. {0} Remeaning Balance is {1}", AccountNumber, Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount();
            BankAccount bank2 = new BankAccount();

            Console.WriteLine("Account Details");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Details of 1st Account");
            bank1.AccountNumber = 236548;
            bank1.AccountHolderName = "XYZ";
            bank1.Balance = 1000;

            bank1.display();

            Console.WriteLine("Details of 2nd Account");
            bank2.AccountNumber = 56328;
            bank2.AccountHolderName = "ZYX";
            bank2.Balance = 500;

            bank2.display();

            bank2.Transfer(bank1);
            Console.WriteLine("Transfer After Balance");

            bank1.ShowBalance();
            bank2.ShowBalance();


            Console.ReadKey();
        }
    }
}
