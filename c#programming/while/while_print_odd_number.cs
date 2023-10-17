using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 20;
            while (counter <= 30)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine("{0} is odd number", counter);
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}

