namespace LeetCode.T1001_T1500.T1401_T1500.T1493_LongestSubarrayOf1sAfterDeletingOneElement;

public class T_LongestSubarrayOf1sAfterDeletingOneElement
{
    public int LongestSubarray(int[] nums)
    {
        var longestSubarray = 0;

        var current = 0;
        var toDelete = 0;
        var zeroCount = 0;

        foreach (var num in nums)
        {
            if (num == 0)
            {
                zeroCount++;
                continue;
            }

            if (zeroCount > 1)
            {
                zeroCount = 0;
                toDelete = 0;
                current = 1;
                if (current >= longestSubarray)
                    longestSubarray = current;
                continue;
            }

            if (zeroCount == 1)
            {
                zeroCount = 0;
                current -= toDelete;
                toDelete = current;
                current++;
                if (current >= longestSubarray)
                    longestSubarray = current;
                continue;
            }

            current++;
            if (current >= longestSubarray)
                longestSubarray = current;
        }

        if (longestSubarray == nums.Length)
            return longestSubarray - 1;

        return longestSubarray;
    }
}
