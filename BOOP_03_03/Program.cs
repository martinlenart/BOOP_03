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
