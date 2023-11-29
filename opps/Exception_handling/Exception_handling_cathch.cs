using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_cathch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,res=0;

            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                res = num1 / num2;
            }
            catch(Exception ee)
            {
                Console.WriteLine("Cannot divide by zero" + ee);
            }
            Console.WriteLine("Result : "+res);
            Console.WriteLine("Bye");

            Console.ReadLine();
        }
    }
}
