namespace LeetCode.T1501_T2000.T1901_T2000.T1920_BuildArrayFromPermutation;

public class T_BuildArrayFromPermutation
{
    public int[] BuildArray(int[] nums)
    {
        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[nums[i]];
        }

        return result;
    }
}
