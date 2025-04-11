namespace LeetCode.T3001_T3500.T3301_T3400.T3375_MinimumOperationsToMakeArrayValuesEqualToK;

public class T_MinimumOperationsToMakeArrayValuesEqualToK
{
    public int MinOperations(int[] nums, int k)
    {
        var used = new bool[101];
        var result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < k)
                return -1;

            if (nums[i] > k && !used[nums[i]])
            {
                used[nums[i]] = true;
                result++;
            }
        }

        return result;
    }
}
