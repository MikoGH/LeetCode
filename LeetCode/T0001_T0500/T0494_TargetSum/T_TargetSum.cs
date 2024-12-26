namespace LeetCode.T0001_T0500.T0494_TargetSum;

public class T_TargetSum
{
    public int FindTargetSumWays(int[] nums, int target)
    {
        return CountEqualSum(nums, 0, 0, target);
    }

    private int CountEqualSum(int[] nums, int i, int sum, int target)
    {
        if (i >= nums.Length)
        {
            if (sum == target)
                return 1;
            return 0;
        }

        return CountEqualSum(nums, i + 1, sum + nums[i], target) + CountEqualSum(nums, i + 1, sum - nums[i], target);
    }
}
