using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q10_assending_order_using_arry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Elements of array in sorted ascending order: ");
            for(int i =0; i < n; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();
        }
    }
}
