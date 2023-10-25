using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q3_account_method
{
    internal class Program
    {
        static void account(int amt,int bal)
        {
            int deposit = bal + amt;
            int withdrawal = bal - amt;

            Console.WriteLine("Remaining Amount = " + deposit);
            Console.WriteLine("Remaining Amount = " + withdrawal);
        }
        public static void Main(string[] args)
        {
                int accno, amount, balnce=500;

                Console.WriteLine("Enter Account Number ");
                accno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Amount :-");
                amount = Convert.ToInt32(Console.ReadLine());

                account(amount,balnce);
                Console.ReadKey();
        }
    }
}
