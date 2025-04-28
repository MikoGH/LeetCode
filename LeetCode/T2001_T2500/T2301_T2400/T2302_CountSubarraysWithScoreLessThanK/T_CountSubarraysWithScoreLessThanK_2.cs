namespace LeetCode.T2001_T2500.T2301_T2400.T2302_CountSubarraysWithScoreLessThanK;

public class T_CountSubarraysWithScoreLessThanK_2
{
    public long CountSubarrays(int[] nums, long k)
    {
        long result = 0;

        long sum = 0;
        var left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum * (right + 1 - left) >= k)
            {
                sum -= nums[left];
                left++;
            }

            result += right - left + 1;
        }

        return result;
    }
}
