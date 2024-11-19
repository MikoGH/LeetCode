namespace LeetCode.T2001_T2500.T2461_MaximumSumOfDistinctSubarraysWithLengthK;

public class T_MaximumSumOfDistinctSubarraysWithLengthK
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        var counts = new int[(int)1e5 + 1];

        var count_repeats = 0;
        var sum = 0;
        var max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            counts[nums[i]]++;
            if (counts[nums[i]] > 1)
                count_repeats++;
            if (i < k - 1)
                continue;
            if (count_repeats == 0 && sum > max)
                max = sum;
            sum -= nums[i - k + 1];
            counts[nums[i - k + 1]]--;
            if (counts[nums[i - k + 1]] > 0)
                count_repeats--;
        }

        return max;
    }
}
