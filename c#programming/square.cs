using System;

namespace square
{
    internal class Program
    {
        public static void Main()
        {
            int num, square;
            Console.WriteLine("Enter the Number :- ");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square = " + square);
            Console.ReadKey();
        }
    }
}
