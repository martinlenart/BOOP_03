using System;

namespace BOOP_03_10
{
    class Program
    {
        static void Main(string[] args)
        {
			// Array initialization
			
			// Classic way
			char[] charArray1 = { 'a', 'e', 'i', 'o', 'u' };

			int[,] rectangularMatrix1 =	{{0,1,2},
										 {3,4,5},
										 {6,7,8}};

			int[][] jaggedMatrix1 = { new int[] {0,1,2,3},
									 new int[] {4,5,6,7,8,9}, 
                                     new int[] {10,11}};


			// Implictly types way
			var charArray2 = new char [] { 'a', 'e', 'i', 'o', 'u' };

			var rectangularMatrix2 =  new int [,]{{0,1,2},
												 {3,4,5},
												 {6,7,8}};

			var jaggedMatrix2 = new int [][]{ new int[] {0,1,2,3},
											 new int[] {4,5,6,7,8,9},
											 new int[] {10,11}};


			// for 1 dimensional arrays an even simplier syntax is available if the compiler can infer the type 
			var charArray3 = new [] { 'a', 'e', 'i', 'o', 'u' };
			var intArray = new[] { 1, 2, 3 };
			var boolArray = new[] { true, false, false, true };
			var decimalArray = new[] { 0M, 1.1M, 2.2M };
		}
    }
}
