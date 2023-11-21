using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Saving_and_Current
{
    interface Bank
    {
        string Deposite(int ActNo, int Amount);
    }
    class Saving : Bank
    {
        public int ActNo;
        public int Balnce = 1000;
        public int Intrest = 200;
        public string Deposite(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balnce = Balnce + Amount + Intrest;
            Console.WriteLine();
            Console.WriteLine("-------------Saving Account--------------");
            return "The Account No. " + ActNo + "\nDeposite Succesfully in Saving Account remaining Balnce is : " + Balnce;
        }
    }
    class Current : Bank
    {
        public int ActNo;
        public int Balnce = 1000;
        public string Deposite(int ActNo, int Amount)
        {
            this.ActNo = ActNo;
            Balnce = Balnce + Amount ;
            Console.WriteLine();
            Console.WriteLine("-------------Current Account--------------");
            return "The Account No. " + ActNo + "\nDeposite Succesfully in Current Account remaining Balnce is : " + Balnce;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            string Result = b.Deposite(1234, 1000);
            Console.WriteLine(Result);

            b = new Current();
            Result = b.Deposite(1234, 1000);
            Console.WriteLine(Result);
            Console.ReadLine()
;        }
    }
}
