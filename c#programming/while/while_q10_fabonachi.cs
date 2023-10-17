using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q10_fabonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int add = num1 + num2;
            int i = 3;

            while(i<10)
            {
                Console.WriteLine(add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                i++;
            }
            Console.ReadKey();
        }
    }
}
