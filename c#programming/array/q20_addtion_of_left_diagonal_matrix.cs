using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q20_addtion_of_left_diagonal_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Input the size of the square matrix : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n1, n2];

            int i = 0;
            int j = 0;

            Console.WriteLine("Input elements in the first matrix :");

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is :");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            Console.WriteLine("Addition of the left Diagonal elements is :");
            for (j = 0; j < n1; j++)
            {
                sum = sum + array[j, n2 - 1 - j];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
