namespace LeetCode.T1501_T2000.T1701_T1800.T1749_MaximumAbsoluteSumOfAnySubarray;

public class T_MaximumAbsoluteSumOfAnySubarray
{
    public int MaxAbsoluteSum(int[] nums)
    {
        var prefix = new int[nums.Length + 1];

        for (var i = 0; i < nums.Length; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }

        var totalMin = int.MaxValue;
        var totalMax = int.MinValue;

        var result = 0;

        for (var i = 0; i < prefix.Length; i++)
        {
            if (prefix[i] - totalMin > result)
                result = prefix[i] - totalMin;

            if (totalMax - prefix[i] > result)
                result = totalMax - prefix[i];

            if (prefix[i] > totalMax)
                totalMax = prefix[i];

            if (prefix[i] < totalMin)
                totalMin = prefix[i];
        }

        return result;
    }
}
