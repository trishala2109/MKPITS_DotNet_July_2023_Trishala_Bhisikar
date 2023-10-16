using System;

namespace swapping_using_third_variable
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, temp;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("Enter the number 1 :-");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2 :-");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("After Swapping :-" + num1 + " " + num2);
           
            Console.ReadKey();

        }
    }
}
