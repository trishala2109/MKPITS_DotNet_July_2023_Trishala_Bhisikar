using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism_Account
{
    public class Account
    {
        public int ActNo;
        public int Balance = 1000;
        public virtual string Deposite(int Actno,int Amount)
        {
            return "Deposite method of account class";
        }
        public string ShowBalance()
        {
            return "Balance Amount :- " + Balance;
        }
    }
    public class Current : Account
    {
        public override string Deposite(int ActNo,int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance + Amount;
            return "Amount deposite succesfully in current class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            string res = act.Deposite(563214, 2000);
            Console.WriteLine("Account No :- " + act.ActNo);
            Console.WriteLine(res);
            res = act.ShowBalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
