using System;

namespace Excercise_3_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine();
                Console.WriteLine($"i: {i++}");

                int k = 0;
                while (k < 10)
                {
                    Console.WriteLine($"k: {k++}");
                }
            }
        }
    }
}
