using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_verically_table_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter limit");
            flag = Convert.ToInt32(Console.ReadLine());

            int counter, counter1 = 1;

            for (counter = 1; counter <= flag; counter++)
            {
                counter1 = 1;
                while (counter1 <= flag)
                {
                    Console.Write("{0}*{1}={2}", counter, counter1, (counter1 * counter));
                    Console.Write("\t");
                    counter1++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

