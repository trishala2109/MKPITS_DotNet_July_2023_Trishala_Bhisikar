using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 1, result = 0;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            while (counter <= number)
            {
                result = counter * counter * counter;
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", counter,counter,result);
                counter++;
            }
            
            Console.ReadKey();
        }
    }
}

