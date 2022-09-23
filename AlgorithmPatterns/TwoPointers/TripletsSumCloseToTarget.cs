namespace AlgorithmPatterns.TwoPointers
{
    public class TripletsSumCloseToTarget
    {
        public int Run(int[] arr, int target)
        {
            if(arr == null || arr.Length < 3)
                throw new ArgumentException();

            Array.Sort(arr);
            var smallestDiff = int.MaxValue;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                var left = i + 1;
                var right = arr.Length - 1;
                
                while (left < right)
                {
                    var tripletSum = arr[left] + arr[right] + arr[i];
                    var targetDiff = target - tripletSum;

                    if (targetDiff == 0)
                        return tripletSum;

                    if(Math.Abs(targetDiff) < Math.Abs(smallestDiff) || Math.Abs(targetDiff) == Math.Abs(smallestDiff) && targetDiff > smallestDiff)
                        smallestDiff = targetDiff;

                    if (targetDiff > 0)
                        left++;
                    else
                        right--;

                }
            }

            return target - smallestDiff;
        }
    }
}
