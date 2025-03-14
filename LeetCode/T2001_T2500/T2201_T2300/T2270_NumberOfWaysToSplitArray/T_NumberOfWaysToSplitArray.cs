namespace LeetCode.T2001_T2500.T2201_T2300.T2270_NumberOfWaysToSplitArray;

public class T_NumberOfWaysToSplitArray
{
    public int WaysToSplitArray(int[] nums)
    {
        long sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        long current = 0;
        var result = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            current += nums[i];
            if (sum - current <= current)
                result++;
        }

        return result;
    }
}
