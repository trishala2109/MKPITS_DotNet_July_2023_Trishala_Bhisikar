using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2 ;

            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            bool isnum1even = num1 % 2 == 0;
            bool isnum2even = num2 % 2 == 0;

            if ((isnum1even && isnum2even) || (!isnum1even && !isnum2even))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}
