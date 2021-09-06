using System;

namespace BOOP_03_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            string s2 = s1 ?? "nothing";
            Console.WriteLine(s2); // nothing

            s1 ??= "something";
            Console.WriteLine(s1);  // something

            s1 ??= "everything";
            Console.WriteLine(s1);  // something


            System.Text.StringBuilder sb = null;
            s1 = sb?.ToString().ToUpper(); // No error but null
            Console.WriteLine(s1); // empty string

            int? length = sb?.ToString().Length;   //int? can be null
            Console.WriteLine(length);

            s1 = sb?.ToString() ?? "with some text";
            s1 = s1?.ToString().ToUpper();
            length = s1?.ToString().Length;
            Console.WriteLine(s1); // WITH SOME TEXT
            Console.WriteLine(length); // 14 
        }
    }
}
