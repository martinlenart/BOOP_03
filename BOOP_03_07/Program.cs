using System;

namespace BOOP_03_07
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare an array of 5 characters
            char[] vowels = new char[5];              // uninitialized
            int[] numbers = { 10, 25, 30, 35, 43 };   // initialzed

            // Square brackets also index the array, accessing a particular element by position:
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            
            Console.WriteLine(vowels[1]);      // e
            Console.WriteLine(numbers[1]);     // 25

            // for loop is excellent when you need to access by index []
            for (int i = 0; i < vowels.Length; i++)
                Console.Write($"{vowels[i]}{numbers[i]} ");            // a10 e25 i30 o35 u43

            // foreach is excelleny when you want to iterate of all elements
            // but you can only iterate over one enumerable
            Console.WriteLine();
            foreach (char c in vowels)
                Console.Write(c);            // aeiou

            Console.WriteLine();
            foreach (var i in numbers)
                Console.Write($"{i,-4}");            // 10   25   30   35  43

            // Array of string
            Console.WriteLine();
            Console.WriteLine();
            string[] words1 = { "The", "quick", "brown", "fox" }; // initialize by string literals

            foreach (var item in words1)
                Console.WriteLine(item);

            Console.WriteLine();
            string[] words2 = "The slow white dog".Split(' ');   // initialize with string.Split()
            foreach (var item in words2)
                Console.WriteLine(item);
        }

        // Exercise:
        // Make an array of struct Point and class Point, iterate over it and find the point with largest distance from (0,0)
    }
}
