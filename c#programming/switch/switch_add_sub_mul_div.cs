using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_add_sub_mul_div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result=0;
            char op;

            Console.WriteLine("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operator (+,-,*,/) :");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Result {0}" , result);
            Console.ReadKey();
        }
    }
}
