namespace AlgorithmPatterns.TwoPointers
{
	public class TripletsSumToZero
	{
		public int[][] Run(int[] arr)
		{
			Array.Sort(arr);
			var result = new List<List<int>>();

			for (int i = 0; i < arr.Length-2; i++)
			{
				if (i > 0 && arr[i] == arr[i - 1])
					continue;

				FindTriplets(-arr[i], i + 1, arr, result);
			}

			return result.Select(x => x.ToArray()).ToArray();
		}

		private void FindTriplets(int target, int left, int[] arr, List<List<int>> triplets)
		{
			var right = arr.Length - 1;
			while (left < right)
			{
				if (arr[left] + arr[right] < target)
					left++;
				else if (arr[left] + arr[right] > target)
					right--;
				else
				{
					triplets.Add(new List<int> { -target, arr[left], arr[right] });
					left++;
					right--;
					while (left < right && arr[left] == arr[left - 1])
						left++;
					while (left < right && arr[right] == arr[right + 1])
						right--;
				} 
			}
		}
	}
}
