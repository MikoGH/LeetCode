namespace LeetCode.T3001_T3500.T3301_T3400.T3392_CountSubarraysOfLengthThreeWithACondition;

public class T_CountSubarraysOfLengthThreeWithACondition
{
    public int CountSubarrays(int[] nums)
    {
        var count = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i + 1] % 2 == 0 && nums[i] + nums[i + 2] == nums[i + 1] / 2)
            {
                count++;
            }
        }

        return count;
    }
}
