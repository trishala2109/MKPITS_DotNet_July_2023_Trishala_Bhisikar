using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism_accept_from_user_Account_Details
{
    public class Account
    {
        public int ActNo;
        public int Balance = 1000;
        public virtual string Deposite(int ActNo,int Amount)
        {
            return "Deposite Method of account class";
        }
        public string ShowBalance()
        {
            return "Balance Amount :- " + Balance;
        }
    }
    public class Current: Account
    {
        public override string Deposite(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance + Amount;
            return "Amount deposite successfully in current class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();

            Console.Write("Enter Account Number :- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Deposite Amount enter :-");
            int amount = Convert.ToInt32(Console.ReadLine());

            string res = act.Deposite(actno, amount);
            Console.WriteLine(res);

            res = act.ShowBalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
