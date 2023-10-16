using System;


namespace datatype_operator
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2;
            char op;
            int r=0;
            Console.WriteLine("enter the number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator :- ");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    r = num1 + num2;
                    break;
                case '-':
                    r = num1 - num2;
                    break;
                case '*':
                    r = num1 * num2;
                    break;
                case '/':
                    r = num1 / num2;
                    break;
                case '%':
                    r = num1 % num2;
                    break;
                default:
                    Console.WriteLine("invalid Operator");
                    break;
                    
            }
            Console.WriteLine("Result =" + r );
            Console.ReadKey();
        }
            
            
    }
}
