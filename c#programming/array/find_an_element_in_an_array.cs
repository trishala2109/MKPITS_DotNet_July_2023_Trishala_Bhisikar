using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_an_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int mila = 0;
            int usernum;
            Console.WriteLine("enter number to be searched");
            usernum = Convert.ToInt32(Console.ReadLine()); //3
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == usernum)
                {
                    mila = 1;
                    break;
                }
            }

            if (mila == 1)
            {
                Console.WriteLine("num {0} is found in an array", usernum);
            }
            else
            {
                Console.WriteLine("number is not found in an array");
            }

            Console.ReadKey();

        }
    }
}
