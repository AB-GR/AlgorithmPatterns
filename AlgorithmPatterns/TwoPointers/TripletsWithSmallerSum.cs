namespace AlgorithmPatterns.TwoPointers
{
	public class TripletsWithSmallerSum
	{
		public int Run(int[] arr, int target)
		{
			var count = 0;
			Array.Sort(arr);

			for (int i = 0; i < arr.Length - 2; i++)
			{
				count += SearchPairs(target - arr[i], arr, i + 1);
			}

			return count;
		}

		private int SearchPairs(int newTarget, int[] arr, int start)
		{
			int count = 0;

			var left = start;
			var right = arr.Length - 1;

			while(left < right)
			{
				if (arr[left] + arr[right] < newTarget)
				{
					count += right - left;
					left++;
				}
				else
				{
					right--;
				}
			}

			return count;
		}
	}
}
