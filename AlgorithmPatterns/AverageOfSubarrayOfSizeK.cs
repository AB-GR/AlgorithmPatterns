namespace AlgorithmPatterns
{
	public class AverageOfSubarrayOfSizeK
	{
		public double[] Run(int[] arr, int k)
		{
			var result = new double[arr.Length - k + 1];
			double sum = 0;
			var i = 0;
			for (int j = 0; j < arr.Length; j++)
			{
				sum += arr[j];

				if(j >= k - 1)
				{
					result[i] = sum / k;
					sum -= arr[i];
					i++;
				}
			}

			return result;
		}
	}
}
