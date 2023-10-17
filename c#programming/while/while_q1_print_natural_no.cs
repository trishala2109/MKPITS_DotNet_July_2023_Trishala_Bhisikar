using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q1_print_natural_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Console.WriteLine("The first 1 to 10 natural Number is");

            while(counter<=10)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
