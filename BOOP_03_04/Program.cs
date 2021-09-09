using System;

namespace BOOP_03_04
{
    class Program
    {
        public enum MonthOfYear
        {
            Undefined = 0,

            January = 0b1, February = 0b1 << 1, March = 0b1 << 2,
            April = 0b1 << 3, May = 0b1 << 4, June = 0b1 << 5,
            July = 0b1 << 6, August = 0b1 << 7, September = 0b1 << 8,
            October = 0b1 << 9, November = 0b1 << 10, December = 0b1 << 11,

            Q1 = January | February | March,
            Q2 = April | May | June,
            Q3 = July | August | September,
            Q4 = October | November | December
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
