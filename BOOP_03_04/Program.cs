using System;

namespace BOOP_03_04
{
    class Program
    {
        public enum MonthOfYear
        {
            January, February , March,
            April, May, June,
            July, August, September,
            October, November, December
        }
        static void Main(string[] args)
        {
            //foreach statement

            // string is an example of an enumerable
            string s1 = "The quick brown fox";
            foreach (char c in s1)
            {
                Console.Write($"{c,4}");
            }

            // in .NET most types that has collections are enumerable, example on the enum,
            // notice I use a trick with typeof() to get access to the collection in the type.
            Console.WriteLine();
            foreach (MonthOfYear item in typeof(MonthOfYear).GetEnumValues())
            {
                Console.WriteLine(item);
            }
        }
    }
}
//Exercises:
//1.    Modify above code so in the foreach-loop each character in s1 that is not a ' ' is written
//2.    Use a foreach-loop to print out each member PlayingCardColor (in region exercise) and the integer constant the
//      member is associated with.
