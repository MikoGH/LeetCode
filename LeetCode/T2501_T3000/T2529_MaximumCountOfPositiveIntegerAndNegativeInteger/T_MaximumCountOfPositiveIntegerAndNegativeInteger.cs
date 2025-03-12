namespace LeetCode.T2501_T3000.T2529_MaximumCountOfPositiveIntegerAndNegativeInteger;

public class T_MaximumCountOfPositiveIntegerAndNegativeInteger
{
    public int MaximumCount(int[] nums)
    {
        var l = -1;
        var r = nums.Length;
        while (l + 1 < r)
        {
            var s = (l + r) >> 1;
            if (nums[s] >= 0)
            {
                r = s;
            }
            else
            {
                l = s;
            }
        }

        var negativeEndPos = l;
        var negativeCount = l + 1;

        r = nums.Length;

        while (l + 1 < r)
        {
            var s = (l + r) >> 1;
            if (nums[s] > 0)
            {
                r = s;
            }
            else
            {
                l = s;
            }
        }

        var positiveStartPos = r;
        var positiveCount = nums.Length - r;

        return Math.Max(negativeCount, positiveCount);
    }
}
