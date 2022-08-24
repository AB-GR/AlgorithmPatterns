namespace AlgorithmPatterns.SlidingWindow
{
	public class MaximumSumSubarrayOfSizeK
	{
		public double Run(int[] arr, int k)
		{
			double maxSum = 0;
			double sum = 0;
			var i = 0;
			for (int j = 0; j < arr.Length; j++)
			{
				sum += arr[j];

				if (j >= k - 1)
				{
					maxSum = Math.Max(maxSum, sum);
					sum -= arr[i];
					i++;
				}
			}

			return maxSum;
		}
	}
}
