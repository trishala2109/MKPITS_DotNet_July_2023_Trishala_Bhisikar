using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_keyword
{
    internal class Program
    {
        static int calculate(params int[] num)
        {
            int i, total = 0;
            for(i=0; i<num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int result = calculate (1, 2, 3,4,5);
            Console.WriteLine("Total = " + result);
            Console.ReadKey();
        }
    }
}
