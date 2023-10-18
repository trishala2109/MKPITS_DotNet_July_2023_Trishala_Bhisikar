using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 1, result = 0;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                result = counter * counter * counter;
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2} ", counter, counter, result);
                counter++;
            } while (counter <= number);
            Console.ReadKey();
        }
    }
}
