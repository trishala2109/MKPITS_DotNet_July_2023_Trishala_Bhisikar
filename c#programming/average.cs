using System;

namespace average
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, num3, num4;
            int result;

            Console.WriteLine("Enter the First number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth number:");
            num4 = Convert.ToInt32(Console.ReadLine());

            result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Average =" + result);
            Console.ReadKey();

        }
    }
}
