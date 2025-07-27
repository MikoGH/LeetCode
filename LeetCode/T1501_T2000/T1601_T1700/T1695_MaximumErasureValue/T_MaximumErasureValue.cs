namespace LeetCode.T1501_T2000.T1601_T1700.T1695_MaximumErasureValue;

public class T_MaximumErasureValue
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        var maxSum = 0;
        var sum = 0;
        var dct = new Dictionary<int, int>();

        var j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (j < nums.Length && (!dct.TryGetValue(nums[j], out var count) || count == 0))
            {
                sum += nums[j];
                dct.TryAdd(nums[j], 0);
                dct[nums[j]]++;
                j++;
            }
            if (sum > maxSum)
                maxSum = sum;
            sum -= nums[i];
            dct[nums[i]]--;
        }

        return maxSum;
    }
}
