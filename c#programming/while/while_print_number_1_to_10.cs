using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_print_number_1_to_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while(counter<=10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
