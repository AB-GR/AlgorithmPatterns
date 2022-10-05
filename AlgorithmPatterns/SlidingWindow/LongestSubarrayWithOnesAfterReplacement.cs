namespace AlgorithmPatterns.SlidingWindow
{
	public class LongestSubarrayWithOnesAfterReplacement
	{
		public int Run(int[] arr, int k)
		{
			var longest1Subarray = 0;
			var left = 0;
			int right;
			for (right = 0; right < arr.Length; right++)
			{
				if (arr[right] != 1)
				{
					longest1Subarray = Math.Max(longest1Subarray, right - left);
					left = right + 1;
				}
			}

			if(right >= left)
			{
				longest1Subarray = Math.Max(longest1Subarray, right - left);
			}

			return longest1Subarray;
		}
	}
}
