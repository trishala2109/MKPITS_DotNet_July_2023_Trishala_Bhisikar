using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean
{
    internal class Program
    {
        public static void Main()
        {
            Boolean b;
            Console.WriteLine("Enter the value :-");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("value =" + b);
            Console.ReadKey();
        }
    }
}
