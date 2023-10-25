using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_method
{
    internal class Program
    {
        static void factorial(int number)//method with one integer parameter
        {
            int fact = 1;
            
            while(number > 0)
            {
                fact = fact * number;
                number--;
            }
            Console.WriteLine(fact);
        }
        static void Main(string[] args)
        {
            factorial( 5 );
            Console.ReadKey();
        }
    }
}
