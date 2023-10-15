using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q16_vowels_and_consonte
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter the Charcter :");
            ch = Convert.ToChar(Console.ReadLine());

            if( ch=='a' || ch=='e'|| ch=='i'|| ch=='o'|| ch=='u' )
            {
                Console.WriteLine("The alphabates are Vowels");
            }
            else
            {
                Console.WriteLine("The alphabates are Consonant");
            }
            Console.ReadKey();
        }
    }
}
