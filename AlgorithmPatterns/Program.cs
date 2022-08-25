﻿using AlgorithmPatterns.SlidingWindow;
using AlgorithmPatterns.TwoPointers;

namespace AlgorithmPatterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var av = new AverageOfSubarrayOfSizeK();
			var result1 = av.Run(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);

			var max = new MaximumSumSubarrayOfSizeK();
			var result2 = max.Run(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);
			var result3 = max.Run(new int[] { 2, 1, 5, 1, 3, 2 }, 3);

			var sm = new SmallestSubArrayWithGreaterSum();
			var result4 = sm.Run(new int[] { 3, 4, 1, 1, 6 }, 7);

			var longKDifferent = new LongestSubstringWithKDifferentCharacters();
			var result5 = longKDifferent.Run("araaci", 2);
			var result6 = longKDifferent.Run("araaci", 1);
			var result7 = longKDifferent.Run("cbbebi", 3);
			
			var fruits = new FruitsIntoBaskets();
			var result8 = fruits.Run(new[] { 'A', 'B', 'C', 'B', 'B', 'C' });

			var longestSubstr = new LongestSubsrtingWithDistinctCharacters();
			var result9 = longestSubstr.Run("aabccbb");

			var longestSubstrWithReplacement = new LongestSubstringSameLettersAfterReplacement();
			var result10 = longestSubstrWithReplacement.Run("aabccbb", 2);

			var pairWithTargetSum = new PairWithTargetSum();
			var result11 = pairWithTargetSum.Run(new[] { 1, 2, 3, 4, 6 }, 6);

			var removeDuplicates = new RemoveDuplicates();
			var result12 = removeDuplicates.Run(new[] { 2, 3, 3, 3, 6, 9, 9 });

			var squaringASortedArray = new SquaringASortedArray();
			var result13 = squaringASortedArray.Run(new[] { -3, -1, 0, 1, 2 });

			var tripletsSumToZero = new TripletsSumToZero();
			var result14 = tripletsSumToZero.Run(new[] { -3, 0, 1, 2, -1, 1, -2 });

			Console.ReadLine();
		}
	}
}