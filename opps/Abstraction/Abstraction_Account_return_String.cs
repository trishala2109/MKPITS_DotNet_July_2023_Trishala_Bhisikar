using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Account_return_String
{
    abstract class Account
    {
        public int Balance = 1000;
        public int Intrest = 200;
        public int ActNo;

        public abstract string Deposite(int Amount);
        public string ShowBalance()
        {
            return "Total Balance is :- " + Balance;
        }

    }
    class Saving : Account
    {
        public override string Deposite(int Amount)
        {
            Balance = Balance + Amount + Intrest;
            return "Amount Deposited successfully with interest in Saving class";
        }
    }
    class Current : Account
    {
        public override string Deposite(int Amount)
        {
            Balance = Balance - Amount;
            return "Amount Deposited successfully without Intrest in Current class";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account Number :- ");
            int ActNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount :- ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Type (Saving or Current) :- ");
            string type = Console.ReadLine();

            Account act = null;

            if (type == "Saving")
            {
                act = new Saving();
            }
            else if ( type == "Current")
            {
                act = new Current();
            }
            act.ActNo = ActNo;

            string Result = act.Deposite(amount);
            Console.WriteLine(Result);
            Result = act.ShowBalance();
            Console.WriteLine(Result);
            Console.ReadKey();

        }
    }
}


