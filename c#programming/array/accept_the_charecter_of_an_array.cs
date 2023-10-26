using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_the_charecter_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[4];
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("enter character");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}", ch[i]);
            }

            Console.ReadKey();

        }
    }
}
