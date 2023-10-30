using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_array_as_a_parameter
{
    internal class Program
    {
        static void display(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of all elements :- " + sum);
        }
        static void Main(string[] args)
        {
            int[] num = { 2, 6, 8 };
            display(num);
            Console.ReadKey();
        }
        
    }
}
