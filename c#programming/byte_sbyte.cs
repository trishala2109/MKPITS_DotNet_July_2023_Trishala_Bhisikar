using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_sbyte
{
    internal class Program
    {
        public static void Main()
        {
            byte x;
            Console.WriteLine("Enter value:-");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Value =" + x);

            sbyte y;
            Console.WriteLine("Enter value:-");
            y = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Value =" + y);

            Console.ReadKey();
        }
    }
}
