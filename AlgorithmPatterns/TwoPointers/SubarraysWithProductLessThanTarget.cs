namespace AlgorithmPatterns.TwoPointers
{
	public class SubarraysWithProductLessThanTarget
	{
		public List<List<int>> Run(int[] arr, int target)
		{
			var result = new List<List<int>>();
			var left = 0;
			var product = 1;
			for (int right = 0; right < arr.Length; right++)
			{
				product *= arr[right];
				while (product >= target && left < arr.Length)
					product /= arr[left++];

				var sub = new List<int>();	
				for (int i = right; i >= left; i--)
				{
					sub.Insert(0, arr[i]);
					result.Add(sub.ToList());
				}
			}

			return result;
		}

		private void PopulateSubarray(List<List<int>> result, int[] arr, int left, int right)
		{
			var sub = new List<int>();
			for (int i = left; i < right; i++)
			{
				sub.Add(arr[i]);
			}

			result.Add(sub);// add all items from left to right
		}
	}
}
