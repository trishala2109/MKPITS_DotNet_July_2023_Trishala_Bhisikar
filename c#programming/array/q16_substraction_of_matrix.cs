using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q16_substraction_of_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 2];
            int[,] array2 = new int[2, 2];
            int[,] array3 = new int[2, 2];

            Console.WriteLine("Input elements in the first matrix :");
            int i = 0;
            int j = 0;

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("Input elements in the second matrix :");

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("The first matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The second matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    array3[i, j] = array1[i, j] - array2[i, j];

                }
            }

            Console.WriteLine("The substraction of matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(array3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

