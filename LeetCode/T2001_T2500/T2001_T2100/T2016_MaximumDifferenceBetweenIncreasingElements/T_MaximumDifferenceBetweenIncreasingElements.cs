namespace LeetCode.T2001_T2500.T2001_T2100.T2016_MaximumDifferenceBetweenIncreasingElements;

public class T_MaximumDifferenceBetweenIncreasingElements
{
    public int MaximumDifference(int[] nums)
    {
        var maxDiff = -1;
        var min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] - min > maxDiff)
                maxDiff = nums[i] - min;

            if (nums[i] < min)
                min = nums[i];
        }

        if (maxDiff <= 0)
            return -1;

        return maxDiff;
    }
}
