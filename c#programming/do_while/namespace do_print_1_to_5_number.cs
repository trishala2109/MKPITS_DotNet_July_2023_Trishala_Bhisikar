using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_print_1_to_5_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine("num ={0}", num);
                num++;
            } while (num <= 5);
            Console.ReadKey();
        }
    }
}
