namespace AlgorithmPatterns.SlidingWindow
{
	public class FruitsIntoBaskets
	{
		public int Run(char[] charArr)
		{
			var dict = new Dictionary<char, int>();
			var maxCount = 0;
			int i = 0;
			for (int j = 0; j < charArr.Length; j++)
			{
				if (dict.ContainsKey(charArr[j]))
					dict[charArr[j]]++;
				else
					dict.Add(charArr[j], 1);

				while (dict.Count > 2)
				{
					dict[charArr[i]]--;
					if (dict[charArr[i]] == 0)
						dict.Remove(charArr[i]);

					i++;
				}

				if (dict.Count == 2)
					maxCount = Math.Max(maxCount, j - i + 1);
			}

			return maxCount;
		}
	}
}
