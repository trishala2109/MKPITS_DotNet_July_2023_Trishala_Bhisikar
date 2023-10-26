using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_refrence
{
    internal class Program
    { 
        static void display(ref int num)
        {
            num = 20;
            Console.WriteLine("Number inside method = " + num);//20
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(ref num);
            Console.WriteLine(" NUmber after passing inside main = " + num);//20
            Console.ReadKey();
        }
    }
}
