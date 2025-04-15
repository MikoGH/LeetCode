namespace LeetCode.T3001_T3500.T3501_T3600.T3512_MinimumOperationsToMakeArraySumDivisibleByK;

public class T_MinimumOperationsToMakeArraySumDivisibleByK
{
    public int MinOperations(int[] nums, int k)
    {
        var sum = nums.Sum();

        return sum % k;
    }
}
