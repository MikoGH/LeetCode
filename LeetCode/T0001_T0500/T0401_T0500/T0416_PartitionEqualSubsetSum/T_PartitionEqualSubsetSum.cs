namespace LeetCode.T0001_T0500.T0401_T0500.T0416_PartitionEqualSubsetSum;

public class T_PartitionEqualSubsetSum
{
    public bool CanPartition(int[] nums)
    {
        Array.Sort(nums);

        var sum = nums.Sum();
        if (sum % 2 == 1)
            return false;
        var halfSum = sum / 2;

        var dp = new int[halfSum + 1][];
        for (int i = 0; i <= halfSum; i++)
            dp[i] = new int[nums.Length + 1];

        for (int i = 1; i <= halfSum; i++)
        {
            for (int j = 1; j < nums.Length + 1; j++)
            {
                var numsIndex = j - 1;
                if (nums[numsIndex] > i)
                {
                    dp[i][j] = dp[i][j - 1];
                    continue;
                }

                dp[i][j] = Math.Max(dp[i][j - 1], nums[numsIndex] + dp[i - nums[numsIndex]][j - 1]);
            }
        }

        return dp[^1][^1] == halfSum;
    }
}
