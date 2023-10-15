using System;
namespace ass_q25_choices
{
    class program
    {
        public static void Main(string[] args)
        {
            int choice, num1, num2;
            float result = 0;

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Choice (1, 2, 3, 4, 5): ");
            choice = Convert.ToInt32(Console.ReadLine());



            if (choice == 1)
            {
                result = num1 + num2;
                Console.WriteLine("\nThe Addition of " + num1 + " and " + num2 + " is: " + result);
            }

            else if (choice == 2)
            {
                result = num1 - num2;
                Console.WriteLine("\nThe Substraction of " + num1 + " and " + num2 + " is: " + result);
            }

            else if (choice == 3)
            {
                result = num1 * num2;
                Console.WriteLine("\nThe Multiplication of " + num1 + " and " + num2 + " is: " + result);
            }

            else if (choice == 4)
            {
                result = num1 / num2;
                Console.WriteLine("\nThe Division of " + num1 + " and " + num2 + " is: " + result);
            }

            else
            {
                Console.WriteLine("\n----- Exit -----");
            }

            Console.ReadKey();
        }
    }
}

