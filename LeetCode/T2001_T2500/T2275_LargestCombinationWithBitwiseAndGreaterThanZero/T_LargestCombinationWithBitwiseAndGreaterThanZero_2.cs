namespace LeetCode.T2001_T2500.T2275_LargestCombinationWithBitwiseAndGreaterThanZero;

public class T_LargestCombinationWithBitwiseAndGreaterThanZero_2
{
    public int LargestCombination(int[] candidates)
    {
        var count = 0;
        var maxCount = 0;

        for (var i = 0; i < 24; i++)
        {
            count = 0;
            foreach (var candidate in candidates)
            {
                count += (candidate & 1 << i) > 0 ? 1 : 0;
            }
            if (count > maxCount)
                maxCount = count;
        }

        return maxCount;
    }
}
