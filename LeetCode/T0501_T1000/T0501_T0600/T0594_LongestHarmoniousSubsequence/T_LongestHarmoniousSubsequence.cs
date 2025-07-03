namespace LeetCode.T0501_T1000.T0501_T0600.T0594_LongestHarmoniousSubsequence;

public class T_LongestHarmoniousSubsequence
{
    public int FindLHS(int[] nums)
    {
        var dct = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dct.TryAdd(nums[i], 0);
            dct[nums[i]]++;
        }

        var keys = dct.Keys.Order().ToArray();

        var result = 0;

        for (int i = 1; i < keys.Length; i++)
        {
            if (keys[i] != keys[i - 1] + 1)
                continue;

            var sum = dct[keys[i]] + dct[keys[i - 1]];
            if (sum > result)
                result = sum;
        }

        return result;
    }
}
