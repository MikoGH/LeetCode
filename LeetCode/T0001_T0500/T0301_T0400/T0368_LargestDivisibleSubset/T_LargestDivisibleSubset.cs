namespace LeetCode.T0001_T0500.T0301_T0400.T0368_LargestDivisibleSubset;

public class T_LargestDivisibleSubset
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);

        var dp = new int[nums.Length];
        var prev = new int[nums.Length];
        Array.Fill(prev, -1);
        var maxIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0 && dp[j] >= dp[i])
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;

                    if (dp[i] > dp[maxIndex])
                        maxIndex = i;
                }
            }
        }

        var result = new List<int>(dp[maxIndex]);

        while (maxIndex != -1)
        {
            result.Add(nums[maxIndex]);
            maxIndex = prev[maxIndex];
        }

        return result;
    }
}
