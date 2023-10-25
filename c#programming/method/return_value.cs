using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_value
{
    internal class Program
    {
        static int addition(int num1,int num2,int op)
        {
            int result = 0;
            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
                result = num1 * num2;
            }
            else if (op == '/')
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number1, number2;
            char opera;

            Console.WriteLine("Enter Number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator (+,-,*,/) ");
            opera = Convert.ToChar(Console.ReadLine());

            int result = addition(number1,number2,opera);
            Console.WriteLine("Result = " + result);

            Console.ReadKey();
        }
    }
}
