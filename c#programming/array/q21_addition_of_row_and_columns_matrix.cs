using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q21_addition_of_row_and_columns_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Input the size of the square matrix: ");
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

            int rowsum = 0;
            int colsum = 0;

            Console.WriteLine("The sum of rows is :");
            for (i = 0; i < n1; i++)
            {
                rowsum = 0;
                for(j = 0; j < n2; j++)
                {
                    rowsum = rowsum + array[i, j];
                }
                Console.WriteLine(rowsum);
            }

            Console.WriteLine("The sum of columns is :");
            for (j = 0; j < n2; j++)
            {
                colsum = 0;
                for(i = 0; i < n1; i++)
                {
                    colsum = colsum + array[i, j];
                }
                Console.WriteLine(colsum);
            }
            Console.ReadKey();
        }
    }
}
