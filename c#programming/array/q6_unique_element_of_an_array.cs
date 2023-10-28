using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6_unique_element_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            int count = 0;

            for(int i =0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                            break;
                        }
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("The unique elements found in the array are :" + array[i]);
                }
            }
            
            Console.ReadLine();
        }
    }
}
