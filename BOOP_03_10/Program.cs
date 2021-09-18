using System;

namespace BOOP_03_10
{
    class Program
    {
		#region Exercise
		struct Point
		{
			public int X, Y;
			public double Vector => Math.Sqrt(X * X + Y * Y);
		}
		public enum PlayingCardColor
		{
			Clubs, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
		}

		public enum PlayingCardValue
		{
			Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
			Knight, Queen, King, Ace                // Poker Value order
		}
		public struct PlayingCard
		{
			public PlayingCardColor Color;
			public PlayingCardValue Value;
		}
		#endregion

		static void Main(string[] args)
        {
			// Array initialization
			
			// Classic way
			char[] charArray1 = { 'a', 'e', 'i', 'o', 'u' };

			int[,] rectangularMatrix1 =	{{0,1,2},
										 {3,4,5},
										 {6,7,8}};

			int[][] jaggedMatrix1 = { new int[] {0,1,2,3},
									 new int[] {4,5,6,7,8,9}, 
                                     new int[] {10,11}};


			// Implictly types way
			var charArray2 = new char [] { 'a', 'e', 'i', 'o', 'u' };

			var rectangularMatrix2 =  new int [,]{{0,1,2},
												 {3,4,5},
												 {6,7,8}};

			var jaggedMatrix2 = new int [][]{ new int[] {0,1,2,3},
											 new int[] {4,5,6,7,8,9},
											 new int[] {10,11}};


			// Simple syntax way
			// for 1 dimensional arrays an even simplier syntax is available if the compiler can infer the type 
			var charArray3 = new [] { 'a', 'e', 'i', 'o', 'u' };
			var intArray = new[] { 1, 2, 3 };
			var boolArray = new[] { true, false, false, true };
			var decimalArray = new[] { 0M, 1.1M, 2.2M };

			#region Hints for Exercise 6 (The Challange)
			//An array of 52 PlayingCard becomes a deck
			PlayingCard[] completeDeck = new PlayingCard[52];

			//Below are two way to loop through an enum type

			Console.WriteLine();
			//Looping through an enum using a for-loop
			for (PlayingCardColor c = PlayingCardColor.Clubs; c <= PlayingCardColor.Spades; c++)
            {
				//Could you imagne to nest another for-loop here iterating through PlayingCardValue?
				Console.WriteLine(c);
            }

			Console.WriteLine();
			//Looping through an enum using a for-loop
			foreach (PlayingCardColor item in typeof(PlayingCardColor).GetEnumValues())
			{
				//Could you imagne to nest another foreach-loop here iterating through PlayingCardValue?
				Console.WriteLine(item);
			}

			#endregion

		}
	}
}
// Exercise:
// 1.	Make 1-dimensionals arrays of the types bool, double, long, string.
//		Initialize them using Array Initialization of type Classic way, Implict type way, Simple syntax way
// 2.   Make a 1-dimensionalan array of struct Point (from region Exercise), initialize using Simple syntax way.
//		Tips: To initialize each element in the array you use (you can set X and Y to different values): new Point { X = 0, Y = 0 }
// 3.	Iterate over the array of type Point and print out all the points.

// 4.    Create a new VS2019 project called DeckOfCards. Setup Git as version control. Copy the types PlayingCardColor, PlayingCardValue, PlayingCard
//      (from region Exercise) into the project. Place the types as same level as class Program, i.e, right under the namespace
// 5.	In Main, make an array of type PlayingCard, call the variable cardDeck1. Initialize the DeckOfCards with 4 playing cards, Ace of Spades, Ace of Clubs,
//		Ace of Hearts, and Ace of Diamonds.
//		Print how many cards cardDeck1 has.
// 6.	Challange: Write code to initialize a complete deck, cardDeck2, of Card with 52 cards, using two nested for-loops.
//		The outer loop, the color of the card, the inner loop the value of the card.  
//		Print how many cards cardDeck2 has
//		Hint1: Open above region "Hints for Exercise 6 (The Challange)"