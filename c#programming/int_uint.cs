using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_uint
{
    internal class Program
    {  
        public static void Main()
        {
            int x;
            Console.WriteLine("Enter value:-");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value =" + x);

            uint y;
            Console.WriteLine("Enter value:-");
            y = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Value =" + y);

            Console.ReadKey();
        }
    }
}
