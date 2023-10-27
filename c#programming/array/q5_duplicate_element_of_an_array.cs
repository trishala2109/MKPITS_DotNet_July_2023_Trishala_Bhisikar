using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5_duplicate_element_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            int count = 0;

            for(int i = 0; i <= 2; i++)
            {
                Console.Write("element - " + i + " ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i <= 2; i++)
            {
                for (int j = i+1; j <= 2; j++)
                {
                        if (number[i] == number[j])
                        {
                            count++;
                            break;
                        }
                }
            }
            
            Console.WriteLine("The duplicate elements found in the array are :" + count);
            
            Console.ReadKey();
        }
    }
}
