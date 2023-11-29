using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling__catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0;
            int res = num1 / num2;  // error will come here and program are terminated
            Console.WriteLine("Result : " + res);
            Console.ReadLine();
        }
    }
}
