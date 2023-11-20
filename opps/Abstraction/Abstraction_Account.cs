using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Account
{
    abstract class Account
    {
        public abstract void Deposite();
        public void ShowBalance()
        {
            Console.WriteLine("Balance Method");
        }
    }
    class Saving:Account
    {
        public override void Deposite()
        {
            Console.WriteLine("hello from Deposite method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.Deposite();
            act.ShowBalance();
            Console.ReadLine();
        }
    }
}
