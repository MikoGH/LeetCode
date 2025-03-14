namespace LeetCode.T3001_T3500.T3101_T3200.T3105_LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

public class T_LongestStrictlyIncreasingOrStrictlyDecreasingSubarray
{
    public int LongestMonotonicSubarray(int[] nums)
    {
        var longestIncreasing = 1;
        var longestDecreasing = 1;
        var currentIncreasing = 1;
        var currentDecreasing = 1;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                if (currentDecreasing > longestDecreasing)
                    longestDecreasing = currentDecreasing;
                if (currentIncreasing > longestIncreasing)
                    longestIncreasing = currentIncreasing;
                currentDecreasing = 1;
                currentIncreasing = 1;
            }
            else if (nums[i] < nums[i + 1])
            {
                currentIncreasing++;
                if (currentDecreasing > longestDecreasing)
                    longestDecreasing = currentDecreasing;
                currentDecreasing = 1;
            }
            else
            {
                currentDecreasing++;
                if (currentIncreasing > longestIncreasing)
                    longestIncreasing = currentIncreasing;
                currentIncreasing = 1;
            }
        }
        if (currentDecreasing > longestDecreasing)
            longestDecreasing = currentDecreasing;
        if (currentIncreasing > longestIncreasing)
            longestIncreasing = currentIncreasing;

        if (longestIncreasing >= longestDecreasing)
            return longestIncreasing;

        return longestDecreasing;
    }
}
