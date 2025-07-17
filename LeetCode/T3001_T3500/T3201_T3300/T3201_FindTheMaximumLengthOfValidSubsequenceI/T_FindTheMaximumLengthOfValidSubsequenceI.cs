namespace LeetCode.T3001_T3500.T3201_T3300.T3201_FindTheMaximumLengthOfValidSubsequenceI;

public class T_FindTheMaximumLengthOfValidSubsequenceI
{
    public int MaximumLength(int[] nums)
    {
        var countEven = 0;
        var d = nums[0] % 2;
        if (d == 0)
            countEven++;

        var len = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            var cur = nums[i] % 2;
            if (d != cur)
            {
                d = cur;
                len++;
            }
            if (d == 0)
                countEven++;
        }

        return Math.Max(Math.Max(countEven, nums.Length - countEven), len);
    }
}
