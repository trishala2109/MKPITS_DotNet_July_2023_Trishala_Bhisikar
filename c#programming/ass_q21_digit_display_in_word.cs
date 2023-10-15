using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q21_digit_display_in_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            string word=null; 

            Console.WriteLine("Enter Number");
            digit = Convert.ToInt32(Console.ReadLine());

            if(digit==0)
            {
                word = "Zero";
            }

            else if (digit == 1 )
            {
                word = "one";
            }
            else if (digit == 2 )
            {
                word = "two";
            }
            else if (digit == 3 )
            {
                word = "three";
            }
            else if (digit == 4 )
            {
                word = "four";
            }
            else if (digit == 5 )
            {
                word = "five";
            }
            else if (digit == 6 )
            {
                word = "six";
            }
            else if (digit == 7 )
            {
                word = "seven";
            }
            else if (digit == 8 )
            {
                word = "eight";
            }
            else if (digit == 9 )
            {
                word = "nine";
            }
            else
            {
                Console.WriteLine("Invalid ! Number");
            }
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
