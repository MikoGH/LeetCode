namespace LeetCode.T2501_T3000.T2901_T3000.T2966_DivideArrayIntoArraysWithMaxDifference;

public class T_DivideArrayIntoArraysWithMaxDifference
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = new int[nums.Length / 3][];
        for (int i = 0; i < result.Length; i++)
            result[i] = new int[3];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i / 3][i % 3] = nums[i];
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i][2] - result[i][0] > k)
                return [];
        }

        return result;
    }
}
