using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q14_2D_array_print_the_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            Console.WriteLine("Input elements in the matrix :");
            int i = 0;
            int j = 0;

            for( i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i ,j );
                    array1[i,j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            Console.WriteLine("The matrix is :");
            for( i = 0; i < 3; i++)
            {
                for( j = 0; j < 3; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
