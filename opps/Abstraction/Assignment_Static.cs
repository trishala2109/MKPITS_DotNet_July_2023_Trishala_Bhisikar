using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Static
{
   class MathOperation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation math = new MathOperation();

            Console.Write("Enter Number 1 :- ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 :- ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = MathOperation.Add(num1,num2);
            int multiply = math.Multiply(num1, num2);

            Console.WriteLine("Addition :- " + sum);
            Console.WriteLine("Multiplication :- " + multiply);
            Console.ReadLine();
        }
    }
}
