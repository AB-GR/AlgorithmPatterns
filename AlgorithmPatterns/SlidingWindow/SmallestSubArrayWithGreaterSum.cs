namespace AlgorithmPatterns
{
	public class SmallestSubArrayWithGreaterSum
	{
		public int Run(int[] arr, int s)
		{
			double sum = 0;
			var minLength = Int32.MaxValue;
			var i = 0;
			for (int j = 0; j < arr.Length; j++)
			{
				sum += arr[j];

				while (sum >= s)
				{
					minLength = Math.Min(minLength, j - i + 1);
					sum -= arr[i];
					i++;
				}
			}

			return minLength == Int32.MaxValue ? 0 : minLength;
		}
	}
}
