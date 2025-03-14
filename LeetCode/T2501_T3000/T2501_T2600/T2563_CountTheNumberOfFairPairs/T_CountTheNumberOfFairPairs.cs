namespace LeetCode.T2501_T3000.T2501_T2600.T2563_CountTheNumberOfFairPairs;

public class T_CountTheNumberOfFairPairs
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);
        long count = 0;
        var left = nums.Length;
        var right = nums.Length - 1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (left <= i)
                left = i + 1;

            while (left > i + 1 && nums[i] + nums[left - 1] >= lower)
                left--;

            while (right >= left && nums[i] + nums[right] > upper)
                right--;

            if (left > right)
                continue;

            count += right - left + 1;
        }

        return count;
    }
}
