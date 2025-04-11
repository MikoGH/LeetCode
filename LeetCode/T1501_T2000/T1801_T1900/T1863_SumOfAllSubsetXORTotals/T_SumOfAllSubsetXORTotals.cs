namespace LeetCode.T1501_T2000.T1801_T1900.T1863_SumOfAllSubsetXORTotals;

public class T_SumOfAllSubsetXORTotals
{
    int _totalSum = 0;

    public int SubsetXORSum(int[] nums)
    {
        BackTracking(nums, 0, 0);

        return _totalSum;
    }

    private void BackTracking(int[] nums, int index, int prevXor)
    {
        var currentXor = prevXor ^ nums[index];

        _totalSum += currentXor;

        if (index == nums.Length - 1)
            return;

        BackTracking(nums, index + 1, currentXor);
        BackTracking(nums, index + 1, prevXor);
    }
}
