using System;

namespace BOOP_03_11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char secondToLast = vowels[^2];    // 'o'

            Index first = 0;
            Index last = ^1;
            char firstElement = vowels[first]; // 'a'
            char lastElement = vowels[last];   // 'u'

            char[] slice1 = vowels[..2];     // 'a', 'e'
            char[] slice2 = vowels[2..];    // 'i', 'o', 'u'
            char[] slice3 = vowels[2..3];   // 'i'
            char[] slice4 = vowels[^2..];     // 'o', 'u'

            Range firstTwoRange = 0..2;
            char[] slice5 = vowels[firstTwoRange]; // 'a', 'e'

            Console.WriteLine(lastElement);  // u
            Console.WriteLine(slice4);       // ou
            Console.WriteLine(slice3);       // i
        }
    }

    //Exercises
    //1.    Create a new sub array using slicing
}
