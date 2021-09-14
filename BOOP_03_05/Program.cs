using System;

namespace BOOP_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // infinite while
            int i = 0;
            while (i<100)
            {
                Console.Write($"{i,4}");

                if (++i % 20 == 0)
                    Console.WriteLine();

                //break infinite loop after 5 iterations
                if (i >= 2)
                    break;
            }

            // string is an example of an enumerable
            Console.WriteLine();
            string s1 = "The quick brown fox";
            foreach (char c in s1)
            {
                Console.Write($"{c,4}");

                if (c == 'b')
                    break;
            }
        }
    }
}
//1.    Write an infinite for-loop and break after 100 iterations
//2.	Write two nested for-loops (a for-loop in a for-loop). The outer loop counts down from 50 to 0, and for each count down the 
//		inner loop counts up 1..10. Break the inner loop at count 5 or larger.
//		Break the outer loop at count 25 or less. Print out in below form:
//		50: 1, 2, 3, 4, 5, 
//		49: 1, 2, 3, 4, 5,
//		...
//		25: 1, 2, 3, 4, 5, 