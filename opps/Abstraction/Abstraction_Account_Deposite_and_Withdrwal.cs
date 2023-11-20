using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Account_Deposite_and_Withdrwal
{
    abstract class Account
    {
        public int Balance = 1000;
        public int Intrest = 200;
        public abstract void Deposite(int Amount);
        public abstract void Withdrawl(int Amount);
        public void ShowBalance()
        {
            Console.WriteLine("Total Balance :- " + Balance);
        }
    }
    class Saving : Account
    {
        public override void Deposite(int Amount)
        {
            Balance = Balance + Amount + Intrest;
        }
        public override void Withdrawl(int Amount)
        {
            Balance = Balance - Amount;
        }
    }
    class Current : Account
    {
        public override void Deposite(int Amount)
        {
            Balance = Balance + Amount;
        }
        public override void Withdrawl(int Amount)
        {
            Balance = Balance - Amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number :- ");
            int ActNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount :- ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Acount Type (Saving or Current) :- ");
            string acttype = Console.ReadLine();

            Console.WriteLine("Enter Deposite or Withdrwal");
            string type = Console.ReadLine();

            Account act = null;

            if (acttype == "Saving")
            {
                act = new Saving();
            }
            else if (acttype == "Current")
            {
                act = new Current();
            }

            //-----------------------------------------

            if (type == "Deposite")
            {
                act.Deposite(amount);
            }
            else if (type == "Withdrwl")
            {
                act.Withdrawl(amount);
            }

            act.ShowBalance();
            Console.ReadLine();
        }
    }
}
