namespace LeetCode.T0501_T1000.T0689_MaximumSumOf3NonOverlappingSubarrays;

public class T_MaximumSumOf3NonOverlappingSubarrays
{
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
    {
        var dp = new (int Value, int Pos)[3][];
        for (int i = 0; i < dp.Length; i++)
            dp[i] = new (int Value, int Pos)[nums.Length];

        var sums = new int[nums.Length];
        var sum = 0;
        for (int i = 0; i < k; i++)
            sum += nums[i];
        sums[0] = sum;
        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i];
            sum -= nums[i - k];
            sums[i - k + 1] = sum;
        }

        dp[0][0] = (sums[0], 0);
        for (int i = 1; i < dp[0].Length; i++)
        {
            if (sums[i] > dp[0][i - 1].Value)
            {
                dp[0][i] = (sums[i], i);
                continue;
            }

            dp[0][i] = dp[0][i - 1];
        }

        for (int i = 1; i < dp.Length; i++)
        {
            for (int j = i * k; j < dp[i].Length; j++)
            {
                var curSum = dp[i - 1][j - k].Value + sums[j];
                if (curSum > dp[i][j - 1].Value)
                    dp[i][j] = (curSum, j);
                else
                    dp[i][j] = dp[i][j - 1];
            }
        }

        var result = new int[3];
        var pos = dp[0].Length - 1;
        for (int i = dp.Length - 1; i >= 0; i--)
        {
            pos = dp[i][pos].Pos;
            result[i] = pos;
            pos -= k;
        }

        return result;
    }
}
