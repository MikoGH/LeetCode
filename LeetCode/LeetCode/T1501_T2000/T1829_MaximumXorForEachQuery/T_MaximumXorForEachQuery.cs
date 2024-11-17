namespace LeetCode.T1501_T2000.T1829_MaximumXorForEachQuery;

public class T_MaximumXorForEachQuery
{
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        int t = (int)Math.Pow(2, maximumBit) - 1;

        var results = new int[nums.Length];

        var currentNumber = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currentNumber = currentNumber ^ nums[i];
            results[nums.Length - i - 1] = currentNumber ^ t;
        }

        return results;
    }
}
