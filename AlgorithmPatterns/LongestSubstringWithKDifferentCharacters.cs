namespace AlgorithmPatterns
{
	public class LongestSubstringWithKDifferentCharacters
	{
		public int Run(string s, int k)
		{
			var dict = new Dictionary<char, int>();
			var maxLength = 0;
			int i = 0;
			for (int j = 0; j < s.Length; j++)
			{
				if (dict.ContainsKey(s[j]))
					dict[s[j]]++;
				else
					dict.Add(s[j], 1);

				while(dict.Count > k)
				{
					dict[s[i]]--;
					if (dict[s[i]] == 0)
						dict.Remove(s[i]);

					i++;
				}

				maxLength = Math.Max(maxLength, j - i + 1);
			}

			return maxLength;
		}
	}
}
