using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accepting_value_from_user_method
{
    internal class Program
    {
        static void factorial(int num)//method with one integer value
        {
            int fact = 1;
            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("factorial = " + fact);

        }
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);
            Console.ReadKey();
        }
    }
}
