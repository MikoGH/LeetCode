namespace LeetCode.T2001_T2500.T2401_T2500.T2460_ApplyOperationsToAnArray;

public class T_ApplyOperationsToAnArray
{
    public int[] ApplyOperations(int[] nums)
    {
        int i = 0, j = 0;

        while (i < nums.Length)
        {
            if (nums[i] == 0)
            {
                i++;
                continue;
            }
            if (i < nums.Length - 1 && nums[i] == nums[i + 1])
            {
                nums[j++] = nums[i] * 2;
                i += 2;
                continue;
            }
            nums[j++] = nums[i];
            i++;
        }

        while (j < nums.Length)
        {
            nums[j++] = 0;
        }

        return nums;
    }
}
