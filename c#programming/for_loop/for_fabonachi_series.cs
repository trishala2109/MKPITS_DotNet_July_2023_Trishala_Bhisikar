using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_fabonachi_seris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int counter;
            int add = 0;
            for(counter = 0; counter <=10; counter++)
            {
                Console.WriteLine(add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
            Console.ReadKey();
        }
    }
}
