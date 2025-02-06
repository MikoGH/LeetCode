namespace LeetCode.T1501_T2000.T1800_MaximumAscendingSubarraySum;

public class T_MaximumAscendingSubarraySum
{
    public int MaxAscendingSum(int[] nums)
    {
        var maxSum = nums[0];
        var sum = nums[0];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
            {
                sum += nums[i + 1];
                if (sum > maxSum)
                    maxSum = sum;
            }
            else
                sum = nums[i + 1];
        }

        return maxSum;
    }
}
