using System.Collections;

namespace LeetCode.T2001_T2500.T2275_LargestCombinationWithBitwiseAndGreaterThanZero;

public class T_LargestCombinationWithBitwiseAndGreaterThanZero
{
    public int LargestCombination(int[] candidates)
    {
        var bitCounts = Enumerable.Repeat(0, 24).ToArray();

        foreach (var candidate in candidates)
        {
            for (var i = 0; i < bitCounts.Length; i++)
            {
                bitCounts[i] += (candidate & 1 << i) > 0 ? 1 : 0;
            }
        }

        return bitCounts.Max();
    }
}
