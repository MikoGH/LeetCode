namespace LeetCode.T2001_T2500.T2401_T2500.T2419_LongestSubarrayWithMaximumBitwiseAND;

public class T_LongestSubarrayWithMaximumBitwiseAND
{
    public int LongestSubarray(int[] nums)
    {
        var max = 0;
        var count = 0;
        var maxCount = 1;
        var prev = -1;

        foreach (var num in nums)
        {
            if (num == max && num == prev)
            {
                count++;
                if (count > maxCount)
                    maxCount = count;
            }
            else if (num >= max)
            {
                if (num > max)
                    maxCount = 1;
                max = num;
                count = 1;
            }
            else
            {
                count = 0;
            }

            prev = num;
        }

        return maxCount;
    }
}
