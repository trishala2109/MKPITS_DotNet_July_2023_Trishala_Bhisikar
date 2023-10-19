using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;

            for (i = 0, j = 0; i <= 5; i++, j++)
            {
                Console.WriteLine("i =" + i);
                Console.WriteLine("j =" + j);
            }
            Console.ReadKey();
        }
    }
}
