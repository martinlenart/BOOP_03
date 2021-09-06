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
