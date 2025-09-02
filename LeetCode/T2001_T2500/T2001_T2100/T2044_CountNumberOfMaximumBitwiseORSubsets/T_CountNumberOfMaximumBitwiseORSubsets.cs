namespace LeetCode.T2001_T2500.T2001_T2100.T2044_CountNumberOfMaximumBitwiseORSubsets;

public class T_CountNumberOfMaximumBitwiseORSubsets
{
    int _target = 0;
    int _countTarget = 0;

    public int CountMaxOrSubsets(int[] nums)
    {
        foreach (var num in nums)
        {
            _target |= num;
        }

        BackTracking(nums, 0, 0);

        return _countTarget;
    }

    private void BackTracking(int[] nums, int value, int i)
    {
        if (i >= nums.Length)
        {
            if (value == _target)
                _countTarget++;
            return;
        }

        BackTracking(nums, value | nums[i], i + 1);
        BackTracking(nums, value, i + 1);
    }
}
