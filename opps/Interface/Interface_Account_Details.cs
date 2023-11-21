using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Account_Details
{
    interface Bank
    {
        string Deposite(int ActNo, int Amount);
        string Withdrwal(int ActNo, int Amount);
        string ShowBalance();
    }
    class Account
    {
        public int ActNo;
        public int Balance = 1000;
        public int Intrest = 200;
    }
    class Saving : Account, Bank
    {
        public string Deposite(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance + Amount + Intrest;
            return "The saving Account " + ActNo + " Deposite Amount Sucessfully :- " + Balance;
        }
        public string Withdrwal(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance - Amount;
            return "The saving Account " + ActNo + " Withdrwal Amount Sucessfully :- " + Balance;
        }
        public string ShowBalance()
        {
            return "The Saving Account Number " + ActNo + " Total Balance :- " + Balance;
        }
    }
    class Current : Account, Bank
    {
        public string Deposite(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance + Amount;
            return "The Current Account " + ActNo + " Deposite Amount Sucessfully :- " + Balance;
        }
        public string Withdrwal(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance - Amount;
            return "The Current Account "+ ActNo +" withdrwal Amount Sucessfully :- " + Balance;
        }
        public string ShowBalance()
        {
            return "The Current Account Number "+ ActNo + " Total Balance :- " + Balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account Number :- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount :- ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type :- ");
            string AccountType = Console.ReadLine();
            Console.Write("Enter Transaction Type :- ");
            string TransactionType = Console.ReadLine();

            Bank b =null;
            string res = null;

            if(AccountType == "Saving")
            {
                b = new Saving();
            }
            else if (AccountType == "Current")
            {
                b = new Current();
            }
           
            if (TransactionType ==  "Deposite")
            {
                res = b.Deposite(actno, amount);
            }
            else if (TransactionType == "Withdrwal")
            {
                res = b.Withdrwal(actno, amount);
            }
            Console.WriteLine(res);
            Console.WriteLine(b.ShowBalance());
            Console.ReadLine();
        }
    }
}
