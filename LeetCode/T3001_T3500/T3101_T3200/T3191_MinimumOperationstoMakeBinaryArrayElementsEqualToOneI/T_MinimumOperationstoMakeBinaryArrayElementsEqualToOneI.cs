namespace LeetCode.T3001_T3500.T3101_T3200.T3191_MinimumOperationstoMakeBinaryArrayElementsEqualToOneI;

public class T_MinimumOperationstoMakeBinaryArrayElementsEqualToOneI
{
    public int MinOperations(int[] nums)
    {
        var count = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] == 0)
            {
                nums[i] ^= 1;
                nums[i + 1] ^= 1;
                nums[i + 2] ^= 1;
                count++;
            }
        }

        if (nums[^1] == 0 || nums[^2] == 0)
            return -1;

        return count;
    }
}
