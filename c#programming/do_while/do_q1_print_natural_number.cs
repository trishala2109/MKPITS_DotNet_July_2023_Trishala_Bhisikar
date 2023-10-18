using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_q1_print_natural_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("The first 1 to 10 natural Number is");
            do
            {
                Console.WriteLine( num);
                num++;
            } while (num <= 10);
            Console.ReadKey();
        }
    }
}
