using System.ComponentModel.DataAnnotations;

namespace LeetCode.T2001_T2500.T2101_T2200.T2176_CountEqualAndDivisiblePairsInAnArray;

public class T_CountEqualAndDivisiblePairsInAnArray
{
    public int CountPairs(int[] nums, int k)
    {
        var count = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && (i * j) % k == 0)
                    count++;
            }
        }

        return count;
    }
}
