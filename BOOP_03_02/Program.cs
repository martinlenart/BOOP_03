using System;

namespace BOOP_03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // int i = 50;  // here is the difference to while
            do
            {
                Console.Write($"{i++,5}");

                // use % to set a newline after each 50 .
                if (i % 10 == 0)
                    Console.WriteLine();
            }
            while (i < 50);

            /*
            // infinite do-while
            i = 0;
            do
            {
                Console.Write(".");

                // use % to set a newline after each 50 .
                if (i % 50 == 0)
                    Console.WriteLine();
                i++;
            } while (true);
            */
        }
    }
}
//Exercises:
//1.    Same exercise as in BOOP_03_01 but with a do while. 