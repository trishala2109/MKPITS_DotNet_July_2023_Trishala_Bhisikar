using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while(true)
            {
                Console.WriteLine(number);
                number++;
                if (number < 10)
                    continue;
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}
