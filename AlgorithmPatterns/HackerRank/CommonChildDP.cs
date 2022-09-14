namespace AlgorithmPatterns.HackerRank
{
	public class CommonChildDP
	{
		public int Run(string s1, string s2)
		{
			var t = new int[5001][];
			for (int i = 0; i < 5001; i++)
			{
				t[i] = new int[5001];
			}

			var m = s1.Length;
			var n = s2.Length;

			for (int i = 1; i < m + 1; i++)
			{
				for (int j = 1; j < n + 1; j++)
				{
					if (s1[i-1] == s2[j-1])
						t[i][j] = 1 + t[i - 1][j-1];
					else
						t[i][j] = Math.Max(t[i - 1][j], t[i][j-1]);
				}
			}

			return t[m][n];
		}
	}
}
