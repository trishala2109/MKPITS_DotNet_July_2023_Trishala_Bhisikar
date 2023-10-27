using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_in_search_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int index = 0;
            int flag = 0;
            int usernum;

            Console.WriteLine("Enter Number");
            usernum = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<5; i++)
            {
                if (num[i] == usernum)
                {
                    flag = 1;
                    index = i + 1;
                    break;
                }
            }
            if(flag == 1)
            {
                Console.WriteLine("The position of search index is  :- " + index);
            }
            else
            {
                Console.WriteLine("The number are not found");
            }
            Console.ReadKey();
        }
    }
}

