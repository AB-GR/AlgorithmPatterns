namespace AlgorithmPatterns.HackerRank
{
	public class Player
    {
        public string Name { get; set; }

        public int Score { get; set; }
    }

    public class Checker : IComparer<Player>
    {
        public int Compare(Player a, Player b)
        {
            if (a.Score < b.Score)
            {
                return 1;
            }
            else if (a.Score > b.Score)
            {
                return -1;
            }
            else
            {
                return string.Compare(a.Name, b.Name, StringComparison.Ordinal);
            }
        }
    }

    public class Comparator
    {
        public void Run(List<Player> players)
        {
            players.Sort(new Checker());
            players.ForEach(player => Console.WriteLine($"{player.Name} {player.Score}"));
        }
    }
}
