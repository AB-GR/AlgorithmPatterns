namespace AlgorithmPatterns.TwoPointers
{
	public class SquaringASortedArray
	{
		public int[] Run(int[] sortedArr)
		{
			var length = sortedArr.Length;
			var squares = new int[length];
			var left = 0;
			var right = length - 1;
			int highestSquareIdx = length - 1;
			while (left < right)
			{
				var leftSqr = sortedArr[left] * sortedArr[left];
				var rightSqr = sortedArr[right] * sortedArr[right];
				if(leftSqr > rightSqr)
				{
					squares[highestSquareIdx--] = leftSqr;
					left++;
				}
				else
				{
					squares[highestSquareIdx--] = rightSqr;
					right--;
				}
			}

			return squares;
		}
	}
}
