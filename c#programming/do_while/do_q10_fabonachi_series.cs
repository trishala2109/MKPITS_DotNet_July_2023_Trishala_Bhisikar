using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_q10_fabonachi_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int add = num1 + num2;
            int i = 3;
            Console.Write("fabonachi series: {0} ",add);
            do
            {
                Console.Write("{0} ",add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                i++;
            } while (i < 10);

            Console.ReadKey();
        }
    }
}
