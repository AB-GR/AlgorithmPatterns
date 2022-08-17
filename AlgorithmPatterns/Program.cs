namespace AlgorithmPatterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var av = new AverageOfSubarrayOfSizeK();
			var result = av.Run(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5);
			//var sm = new SmallestSubArrayWithGreaterSum();
			//sm.Run();
			Console.ReadLine();
		}
	}
}