namespace LeetCode.T2001_T2500.T2301_T2400.T2379_MinimumRecolorsToGetKConsecutiveBlackBlocks;

public class T_MinimumRecolorsToGetKConsecutiveBlackBlocks
{
    public int MinimumRecolors(string blocks, int k)
    {
        var count = 0;

        for (var i = 0; i < k; i++)
        {
            if (blocks[i] == 'W')
                count++;
        }

        var minCount = count;

        for (var i = k; i < blocks.Length; i++)
        {
            if (blocks[i] == 'W')
                count++;
            if (blocks[i - k] == 'W')
                count--;
            if (count < minCount)
                minCount = count;
        }

        return minCount;
    }
}
