namespace LeetCode.T3001_T3500.T3401_T3500.T3487_MaximumUniqueSubarraySumAfterDeletion;

public class T_MaximumUniqueSubarraySumAfterDeletion
{
    public int MaxSum(int[] nums)
    {
        var hashSet = new HashSet<int>();
        var result = 0;
        var maxElement = int.MinValue;

        foreach (var num in nums)
        {
            if (num > maxElement)
                maxElement = num;

            if (num <= 0 || hashSet.Contains(num))
                continue;

            result += num;
            hashSet.Add(num);
        }

        return result > 0 ? result : maxElement;
    }
}
