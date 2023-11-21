using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_using_switch_logic
{
    interface Bank
    {
        string Deposite(int ActNo, int Amount);
    }
    class Saving:Bank
    {
        public int ActNo;u
        public int Balance = 1000;
        public int Intrest = 200;
        public string Deposite(int ActNo,int Amount)
        {
            Balance = Balance + Amount + Intrest;
            return "The Saving Account with intrest amount balnce is :  " + Balance;
        }
    }
    class Current:Bank
    {
        public int ActNo;
        public int Balance = 1000;
        
        public string Deposite(int ActNo, int Amount)
        {
            Balance = Balance + Amount ;
            return "The Saving Account with intrest amount balnce is :  " + Balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            Console.Write("Enter Account Number :- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount :- ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type :- ");
            string type = Console.ReadLine();

            switch(type)
            {
                case "Saving":
                    b = new Saving();
                    break;
                case "Current":
                    b = new Current();
                    break;
            }
            string result = b.Deposite(actno, amount);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
