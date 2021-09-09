﻿using System;

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
			Heart = 0b1,
			Diamond = 0b1 << 1,
			Club = 0b1 << 2,
			Spade = 0b1 << 3,

			Red = Heart | Diamond,
			Black = Club | Spade
		}
		public enum PlayingCardValue
		{
			Ace = 1,
			One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
			Knight, Queen, King
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
		}
    }
}
// Exercise:
// 1.	Make 1-dimensionals arrays of the types bool, double, long, string.
//		Initialize them using Array Initialization of type Classic way, Implict type way, Simple syntax way
// 2.   Make a 1-dimensionalan array of struct Point (from region Exercise), initialize using Simple syntax way.
//		Tips: To initialize each element in the array you use (you can set X and Y to different values): new Point { X = 0, Y = 0 }
// 3.	Iterate over the array of type Point and print out all the points.
// 4.	Make an array of type PlayingCard, call the variable DeckOfCards. Initialize the DeckOfCards with 4 playing cards, Ace of Spade, Ace of Club,
//		Ace of Heart, and Ace of Diamonds

// 5.	Challange: Write code to initialize a complete deck of Card with 52 cards, using two nested for-loops.
//		The outer loop, the color of the card, the inner loop the value of the card.  Hint: Exercise BOOP_03_04.