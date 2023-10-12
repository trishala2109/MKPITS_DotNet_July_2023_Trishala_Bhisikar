using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_ulong
{
    internal class Program
    {
        public static void Main()
        {
            long x;
            Console.WriteLine("Enter value:-");
            x = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Value =" + x);

            ulong y;
            Console.WriteLine("Enter value:-");
            y = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Value =" + y);

            Console.ReadKey();
        }
    }
}
