namespace LeetCode.T2501_T3000.T2901_T3000.T2962_CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

public class T_CountSubarraysWhereMaxElementAppearsAtLeastKTimes
{
    public long CountSubarrays(int[] nums, int k)
    {
        var max = nums.Max();
        long result = 0;

        long count = 0;
        var right = 0;
        for (int left = 0; left < nums.Length; left++)
        {
            while (count < k && right < nums.Length)
            {
                if (nums[right] == max)
                    count++;
                right++;
            }
            if (count < k && right == nums.Length)
                break;

            result += nums.Length - right + 1;

            if (nums[left] == max)
                count--;
        }

        return result;
    }
}
