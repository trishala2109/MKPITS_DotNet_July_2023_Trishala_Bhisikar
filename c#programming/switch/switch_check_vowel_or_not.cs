using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_check_vowel_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("Enter the Charecter ");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is a Vowel");
                    break;
                default:
                    Console.WriteLine("It is Consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}
