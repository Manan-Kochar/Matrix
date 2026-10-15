using System;
using System.Collections.Generic;
using System.Text;
//printng product of 2 matrices
namespace Matrix
{
    internal class Question6
    {
        static void Main()
        {
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] product = new int[2, 2];
            Console.WriteLine("Enter elements of the first matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements of the second matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    product[i, j] = matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1] * matrix2[1, j];
                }
            }
            Console.WriteLine("The product of the two matrices is:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(product[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
