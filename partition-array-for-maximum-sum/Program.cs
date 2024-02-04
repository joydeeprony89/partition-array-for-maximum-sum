namespace partition_array_for_maximum_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 6 };
            var sol = new Solution();
            var ans = sol.MaxSumAfterPartitioning(arr, 3);
            Console.WriteLine(ans);
        }
    }
    public class Solution
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            int Dfs(int i)
            {
                if (i >= arr.Length) { return 0; }

                int max = 0;
                int maxSum = 0;
                for (int j = i; j < Math.Min(arr.Length, i + k); j++)
                {
                    max = Math.Max(max, arr[j]);
                    var subarraySize = j - i + 1;
                    var newMaxSum = subarraySize * max;
                    maxSum = Math.Max(maxSum, newMaxSum + Dfs(j + 1));
                }
                return maxSum;
            }

            return Dfs(0);
        }
    }
}
