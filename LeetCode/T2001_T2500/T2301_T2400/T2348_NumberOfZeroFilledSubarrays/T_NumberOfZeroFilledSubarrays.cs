namespace LeetCode.T2001_T2500.T2301_T2400.T2348_NumberOfZeroFilledSubarrays;

public class T_NumberOfZeroFilledSubarrays
{
    public long ZeroFilledSubarray(int[] nums)
    {
        long result = 0;
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                count++;

            if (i == nums.Length - 1 || nums[i] != 0)
            {
                result += CalculateCount(count);
                count = 0;
            }
        }

        return result;
    }

    private long CalculateCount(int value)
    {
        if (value % 2 == 0)
            return (value + 1) * (long)(value >> 1);

        return (value + 1) * (long)(value >> 1) + (value >> 1) + 1;
    }
}
