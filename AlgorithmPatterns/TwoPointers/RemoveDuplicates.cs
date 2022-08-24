namespace AlgorithmPatterns.TwoPointers
{
	public class RemoveDuplicates
	{
		public int Run(int[] sortedArr)
		{
			//var i = 0;
			//for (int j = 1; j < sortedArr.Length; j++)
			//{
			//	if(sortedArr[j] != sortedArr[i])
			//	{
			//		i++;
			//		var temp = sortedArr[j];
			//		sortedArr[j] = sortedArr[i];
			//		sortedArr[i] = temp;
			//	}
			//}

			//return i + 1;

			var nextNonDuplicate = 1;
			for (int i = 0; i < sortedArr.Length; i++)
			{
				if (sortedArr[nextNonDuplicate - 1] != sortedArr[i])
				{
					sortedArr[nextNonDuplicate] = sortedArr[i];
					nextNonDuplicate++;
				}
			}

			return nextNonDuplicate;
		}
	}
}
