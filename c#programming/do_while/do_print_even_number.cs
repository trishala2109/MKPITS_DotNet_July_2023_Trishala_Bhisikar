using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_print_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter=2;
            do
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} is Even Number", counter);
                }
                counter++;
            } while (counter <= 10);
            Console.ReadKey();
        }
    }
}
