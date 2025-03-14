namespace LeetCode.T0501_T1000.T0801_T0900.T0862_ShortestSubarrayWithSumAtLeastK;

public class T_ShortestSubarrayWithSumAtLeastK
{
    public int ShortestSubarray(int[] nums, int k)
    {
        var dp = new long[nums.Length + 1];
        dp[0] = 0;
        int result = nums.Length + 1;
        long min = 0;
        for (int i = 1; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1] + nums[i - 1];

            if (dp[i] - min >= k)
            {
                int j = i - 1;
                while (j >= 0)
                {
                    if (dp[i] - dp[j] >= k)
                    {
                        if (i - j < result)
                            result = i - j;
                        break;
                    }
                    j--;
                }
            }

            if (dp[i] < min)
                min = dp[i];
        }

        if (result == nums.Length + 1)
            return -1;

        return result;
    }
}
