using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_reverse_no_print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter=10;
            do
            {
                Console.WriteLine(counter);
                counter --;
            } while (counter >= 1);
            Console.ReadKey();
        }
    }
}
