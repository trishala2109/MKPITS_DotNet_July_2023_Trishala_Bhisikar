using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance_Account
{
    class Account
    {
        public int actno;
        public int bal = 1000;
        public void Deposit(int amt)
        {
            Console.WriteLine("This is deposit method of account class");
        }
    }
    class Saving : Account
    {
       public void Deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("Amount deposited with interest bal is " + bal);
        }

    }

    class Current : Account
    {
        public void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("amount deposited without interest bal is " + bal);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.actno = 111;
            s.Deposit(1000);

            Current c = new Current();
            c.actno = 121;
            c.deposit(1000);
            Console.ReadKey();
        }
    }
}