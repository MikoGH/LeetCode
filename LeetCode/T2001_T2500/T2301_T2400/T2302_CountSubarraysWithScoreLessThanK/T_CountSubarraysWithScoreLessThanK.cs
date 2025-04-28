namespace LeetCode.T2001_T2500.T2301_T2400.T2302_CountSubarraysWithScoreLessThanK;

public class T_CountSubarraysWithScoreLessThanK
{
    public long CountSubarrays(int[] nums, long k)
    {
        long result = 0;

        long sum = nums[0];
        var right = 0;
        for (int left = 0; left < nums.Length; left++)
        {
            if (right < left)
            {
                right = left;
                sum = nums[left];
            }
            while (right + 1 < nums.Length && (sum + nums[right + 1]) * (right + 2 - left) < k)
            {
                sum += nums[right + 1];
                right++;
            }

            if (sum * (right + 1 - left) < k)
                result += right - left + 1;
            sum -= nums[left];
        }

        return result;
    }
}
