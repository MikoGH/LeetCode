namespace LeetCode.T2001_T2500.T2301_T2400.T2364_CountNumberOfBadPairs;

public class T_CountNumberOfBadPairs
{
    public long CountBadPairs(int[] nums)
    {
        var offsets = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var offset = nums[i] - i;
            if (!offsets.ContainsKey(offset))
                offsets.Add(offset, 0);
            offsets[offset]++;
        }

        var result = GetSum(nums.Length - 1);
        foreach (var offset in offsets.Keys)
        {
            result -= GetSum(offsets[offset] - 1);
        }

        return result;
    }

    private long GetSum(int value)
    {
        if (value % 2 == 0)
            return (value + 1) * (long)(value >> 1);

        return (value + 1) * (long)(value >> 1) + (value >> 1) + 1;
    }
}
