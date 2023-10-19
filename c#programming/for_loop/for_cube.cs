using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter,result=0;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            for (counter = 1; counter <= number; counter++)
            {
                result = counter * counter * counter;
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2}", counter, counter, result);
            }
            Console.ReadKey();
        }
    }
}
