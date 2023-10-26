
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value
{
    internal class Program
    {
        static void display(int num)
        {
            num = 20;
            Console.WriteLine("Number inside the method = " + num);//20
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("Number after passing inside main = " + num);//10
            Console.ReadKey();
        }
    }
}
