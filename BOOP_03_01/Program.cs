using System;

namespace BOOP_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            int i = 0;
            //int i = 50;  // here is the difference to do-while
            while (i < 50)
            {
                Console.Write($"{i++,5}");

                // use % to set a newline after each 50 .
                if (i % 10 == 0)
                    Console.WriteLine();
            }

            /*
            // infinite while
            i = 0;
            while (true)
            {
                Console.Write(".");

                // use % to set a newline after each 50 .
                if (i % 50 == 0)
                    Console.WriteLine();
                i++;
            }
            */
        }
    }
}
//Exercises:
//1.    Write a program that in a while loop calculate the sum of all integers from 0 to and including 100.
//      Write the increasing sum in each iteration
//2.    Modify the program and introduce a bool variable to terminate the while loop so it terminates either when
//      all 100 iterations are done or the sum is greater or equal to 4300 
