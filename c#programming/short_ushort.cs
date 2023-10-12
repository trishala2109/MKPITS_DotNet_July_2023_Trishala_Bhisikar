using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_ushort
{
    internal class Program
    {
        public static void Main()
        {
            short x;
            Console.WriteLine("Enter value:-");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Value =" + x);

            ushort y;
            Console.WriteLine("Enter value:-");
            y = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Value =" + y);

            Console.ReadKey();
        }
    }
}

