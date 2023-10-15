using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pre_increment_apti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = ++i;
            Console.WriteLine("value of i =" + i + "\n value of j =" + j);
            Console.ReadKey();
        }
    }
}
