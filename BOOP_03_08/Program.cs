using System;

namespace BOOP_03_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangular arrays represent an n-dimensional block of memory

            // 2-dimensional rectangular array
            int[,] matrix = new int[3, 3];      // unitialized
            int[,] matrix2 =  {{0,1,2},         // initialized
                               {3,4,5},
                               {6,7,8}};


            // Initialize the array individually
            // The GetLength method of an array returns the length for a given dimension (starting at 0):
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 25 + j * 43;

            // Write the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],-4}");

                Console.WriteLine();
            }

            // Write the matrix2
            Console.WriteLine();
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    Console.Write($"{matrix2[i, j],-4}");

                Console.WriteLine();
            }
        }
    }
}
