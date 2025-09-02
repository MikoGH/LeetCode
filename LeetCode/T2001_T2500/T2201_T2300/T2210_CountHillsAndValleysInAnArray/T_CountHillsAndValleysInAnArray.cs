namespace LeetCode.T2001_T2500.T2201_T2300.T2210_CountHillsAndValleysInAnArray;

public class T_CountHillsAndValleysInAnArray
{
    public int CountHillValley(int[] nums)
    {
        var count = 0;
        var prev = nums[0];

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i - 1])
                prev = nums[i - 1];

            if (nums[i] > prev && nums[i] > nums[i + 1] || nums[i] < prev && nums[i] < nums[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}
