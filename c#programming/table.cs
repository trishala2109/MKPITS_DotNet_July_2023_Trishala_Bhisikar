using System;

namespace table
{
    internal class Program
    {
        static void Main()
        {
            int num;
            int counter;
            int result;
            Console.WriteLine("Enter the Number ");
            num = Convert.ToInt32(Console.ReadLine());

            for (counter = 1; counter <= 10; counter++)
            {
                result = counter * num;
                Console.WriteLine("table = " + num + "*" + counter + "=" + result);
            }

                Console.ReadKey();
        }
    }
}
