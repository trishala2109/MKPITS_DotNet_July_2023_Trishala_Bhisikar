using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Account
{
    interface Bank
    {
        string Deposite(int ActNo, int Amount);
    }
    class Saving : Bank
    {
        public int ActNo;
        public int Balance = 1000;
        public string Deposite(int ActNo,int Amount)
        {
            this.ActNo = ActNo;
            Balance = Balance + Amount;
            return "The Deposite Succesfully Balance is : " + Balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            string res=b.Deposite(1234, 500);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
