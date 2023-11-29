using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, Result = 0;
            Console.WriteLine("Enter number 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                Result = num1 / num2;
            }
            catch(Exception ee)
            {
                Console.WriteLine("Cannot divide by zero" + ee);
            }
            finally
            {
                Console.WriteLine("Result = " + Result);
                Console.WriteLine("bye");
            }
            Console.ReadLine();
        }
    }
}
