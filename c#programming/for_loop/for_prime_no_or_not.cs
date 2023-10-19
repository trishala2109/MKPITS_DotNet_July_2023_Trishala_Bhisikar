using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace for_prime_no_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter, flag = 0;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            for(counter = 2; counter <= number; counter++)
            {
                if(number % 2 ==0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("{0} number is prime",number);
            }
            else
            {
                Console.WriteLine("{0} number is not prime", number);
            }
            Console.ReadKey();
        }
    }
}
