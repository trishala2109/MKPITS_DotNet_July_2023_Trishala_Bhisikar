using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_keyword
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[3];
            num[0] = 111;
            num[1] = 856;
            num[2] = 555;

            Console.WriteLine("num [0] = " + num[0]);
            Console.WriteLine("num [1] = " + num[1]);
            Console.WriteLine("num [2] = " + num[2]);

            Console.ReadKey();
        }
    }
}
