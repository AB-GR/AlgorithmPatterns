namespace AlgorithmPatterns.TwoPointers
{
	public class DutchNationalFlag
	{
		public int[] Run(int[] arr)
		{
			var low = 0;
			var high = arr.Length - 1;

			for(int i = 0; i<= high;)
			{
				if (arr[i] == 0)
				{
					Swap(i, low, arr);
					i++;
					low++;
				}
				else if (arr[i] == 1)
					i++;
				else
				{
					Swap(i, high, arr);
					high--;
				}
			}

			return arr;
		}

		private void Swap(int i, int j, int[] arr)
		{
			var temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	}
}
