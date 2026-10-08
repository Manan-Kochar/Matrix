//using System;
//using System.Collections.Generic;
//using System.Text;
////printing right diagonal elements of a matrix
//namespace Matrix
//{
//    internal class Question2
//    {
//        static void Main()
//        {
//            int[,] matrix = new int[3, 3];
//            Console.WriteLine("Enter elements of the matrix:");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write($"Element [{i + 1},{j + 1}]: ");
//                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            Console.WriteLine("The right diagonal elements of the matrix are:");
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write(matrix[i, 2 - i] + "\t");
//            }
//        }
//    }
//}
