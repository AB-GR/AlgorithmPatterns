namespace AlgorithmPatterns
{
	public class LongestSubstringSameLettersAfterReplacement
	{
		public int Run(string s, int k)
		{
			var maxLen = 0;
			var maxCharRepeatCount = 0;
			var i = 0;
			var dict = new Dictionary<char, int>();
			for (int j = 0; j < s.Length; j++)
			{
				if (dict.ContainsKey(s[j]))
					dict[s[j]]++;
				else
					dict.Add(s[j], 1);

				maxCharRepeatCount = Math.Max(maxCharRepeatCount, dict[s[j]]);

				while (j - i + 1 - maxCharRepeatCount > k)
				{
					dict[s[i]]--;
					if (dict[s[i]] == 0)
						dict.Remove(s[i]);

					i++;
				}

				maxLen = Math.Max(maxLen, j - i + 1);
			}

			return maxLen;
		}
	}
}
