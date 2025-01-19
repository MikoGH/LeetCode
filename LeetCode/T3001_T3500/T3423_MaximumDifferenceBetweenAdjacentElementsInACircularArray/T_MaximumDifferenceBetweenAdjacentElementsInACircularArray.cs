namespace LeetCode.T3001_T3500.T3423_MaximumDifferenceBetweenAdjacentElementsInACircularArray;

public class T_MaximumDifferenceBetweenAdjacentElementsInACircularArray
{
    public int MaxAdjacentDistance(int[] nums)
    {
        var result = 0;
        var abs = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            abs = Math.Abs(nums[i] - nums[i + 1]);
            if (abs > result)
                result = abs;
        }
        abs = Math.Abs(nums[0] - nums[^1]);
        if (abs > result)
            result = abs;

        return result;
    }
}
