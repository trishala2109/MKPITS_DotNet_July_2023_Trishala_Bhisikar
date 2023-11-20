using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Account_details_from_user
{
    abstract class Account
    {
        public int ActNumber;
        public int Intrest = 500;
        public int Balance = 1000;

        public abstract void Deposite(int Amount);
        public void ShowBalance()
        {
            Console.WriteLine("Total Balance is :- "+Balance);
        }
    }
    class Saving : Account
    {
        public override void Deposite(int Amount)
        {
            Balance = Balance + Amount + Intrest;
        }
    }
    class Current : Account
    {
        public override void Deposite(int Amount)
        {
            Balance = Balance + Amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number :- ");
            int ActNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount :- ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type (Saving or Current) :- ");
            string type = Console.ReadLine();

            Account act = null;
            
            if(type == "Saving")
            {
                act = new Saving();
            }
            else if (type == "Current")
            {
                act = new Current();
            }
            act.ActNumber = ActNumber;
            act.Deposite(amount);
            act.ShowBalance();
            Console.ReadLine();
        }
    }
}
