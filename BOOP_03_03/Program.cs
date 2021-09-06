using System;

namespace BOOP_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
			// for loop
			for (int i = 0; i < 50; i++)
			{
				Console.Write($"{i,5}");	// notice I do not increment i here

				// use % to set a newline after each 50 .
				if ((i+1) % 10 == 0)		// notice the difference to the while/do-while. Why?
					Console.WriteLine();
			}

			// You can have more than one variable in the init clause (and in the iteration clause)
			Console.WriteLine();
			for (int i = 0, prevFib = 1, curFib = 1; i < 10; i++)
			{
				Console.Write($"{prevFib,5}");
				int newFib = prevFib + curFib;
				prevFib = curFib; curFib = newFib;
			}

			/*
			//infinite for loop
			Console.WriteLine();
			for (int i = 0; true; i++)
			{
				Console.Write(".");

				// use % to set a newline after each 50 .
				if ((i+1) % 50 == 0)
					Console.WriteLine();
			} 
			*/
		}
	}
}
//Exercises:
//1.    Write a for-loop that counts down from 100, printing out each iteration with 25 numbers in a row
//2.	Write two nested for-loops (a for-loop in a for-loop). The outer loop counts down from 50 to 0, and for each count down the 
//		inner loop counts up 1..10. Print out in below form:
//		50: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
//		49: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
//		...
//		0: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
