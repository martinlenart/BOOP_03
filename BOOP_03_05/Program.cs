using System;

namespace BOOP_03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // infinite while
            int i = 0;
            while (true)
            {
                Console.Write($"{i,4}");

                if (++i % 20 == 0)
                    Console.WriteLine();

                //break infinite loop after 100 iterations
                if (i >= 100)
                    break;
            }

            // string is an example of an enumerable
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
