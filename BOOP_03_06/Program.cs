using System;

namespace BOOP_03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                // skip all even, write only odds
                if (i % 2 == 0)
                    continue;               

                Console.Write($"{i,4}");

                if ((i+1) % 20 == 0)
                    Console.WriteLine();
            }

            // string is an example of an enumerable
            string s1 = "The quick brown fox";
            foreach (char c in s1)
            {
                // skip every blank character
                if (c == ' ')
                    continue;

                Console.Write(c);
            }
        }
    }
}
//1.	Write two nested for-loops (a for-loop in a for-loop). The outer loop counts down from 50 to 0, and for each count down the 
//		inner loop counts up 1..10. Use continue in each loop to skip all odd numbers in both loops.
//		50: 2, 4, 6, 8, 10 
//		48: 2, 4, 6, 8, 10 
//		46: 2, 4, 6, 8, 10
//      ..
//      0: 2, 4, 6, 8, 10
//2.    Break the outer loop when 5 rows has been printed. E.g.,
//		50: 2, 4, 6, 8, 10 
//		48: 2, 4, 6, 8, 10 
//		46: 2, 4, 6, 8, 10
//		44: 2, 4, 6, 8, 10
//		42: 2, 4, 6, 8, 10

