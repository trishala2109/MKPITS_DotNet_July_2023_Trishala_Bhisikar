using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charecter
{
    internal class Program
    {
        static void Main()
        {
            char ch;
            Console.WriteLine("Enter the Name");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The Charecter is =" + ch);
            Console.ReadKey();
        }
    }
}
