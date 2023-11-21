using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Interface_are_delared_same_time
{
    interface Bank
    {
        string Deposite(int ActNo, int Amount);
        string Withdrwal(int ActNo, int Amount);
    }
    class Account
    {
        public int ActNo;
        public int Balance = 1000;
        public int Intrest = 200;
        public string ShowBalnce()
        {
            return "Total Balance : " + Balance;
        }
    }
    class Saving : Account,Bank
    {
        public string Deposite(int ActNo, int Amount)
        {
            Balance = Balance + Amount + Intrest;
            return "The Deposite Sucessfully in saving account with intrest : " + Balance;
        }
        public string Withdrwal(int ActNo, int Amount)
        {
            Balance = Balance - Amount;
            return "The Withdrwal Sucessfully in saving account : " + Balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving b;

            Console.Write("Enter Account Number :- ");
            int ActNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount :- ");
            int amount = Convert.ToInt32(Console.ReadLine());

            b = new Saving();       
            string Result = b.Deposite(ActNo, amount);
            Console.WriteLine(Result);

            b=new Saving();
            Result = b.Withdrwal(ActNo, amount);
            Console.WriteLine(Result);

            Console.WriteLine(b.ShowBalnce());
            Console.ReadLine();
        }
    }
}
