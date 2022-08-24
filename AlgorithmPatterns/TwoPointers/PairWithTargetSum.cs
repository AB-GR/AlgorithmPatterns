namespace AlgorithmPatterns.TwoPointers
{
	public class PairWithTargetSum
	{
		public int[] Run(int[] sortedArr, int sum)
		{
			var start = 0;
			var end = sortedArr.Length - 1;
			while(start < end)
			{
				var temp = sortedArr[start] + sortedArr[end];
				if (temp < sum)
					start++;
				else if(temp > sum)
					end--;
				else
				{
					return new[] { start , end };
				}
			}

			return new[] { -1, -1 };
		}
	}
}
