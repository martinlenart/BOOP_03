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
// Exercise:
// 1.   Make multidimensionals array 3x3 in size of the types bool, double, long, string. Initialize them with some values.
//      Iterate over rows and columns and printout the values using nested for-loops
// 2.   Make an multidimensional array of struct Point, 2x2 in size. Initialize it with 4 different Point cooridinates.
//      - Iterate over the array using two nested foreach-loops and find the longest Vector. Print out the longest Vector.
//      - Iterate over the array using two nested for-loops and find the longest Vector. Print out the longest Vector.
//      - Iterate over the array using two nested while-loops and find the longest Vector. Print out the longest Vector.
//      Which of the nested loop structures were most convenient to work with?