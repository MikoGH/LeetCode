namespace LeetCode.T3001_T3500.T3097_ShortestSubarrayWithORAtLeastKII;

public class T_ShortestSubarrayWithORAtLeastKII
{
    public int MinimumSubarrayLength(int[] nums, int k)
    {
        var bitCounts = Enumerable.Repeat(0, 32).ToArray();
        long result = 0;

        var minLength = nums.Length + 1;

        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            for (int bit = 0; bit < bitCounts.Length; bit++)
            {
                if ((nums[j] & (long)1 << bit) > 0)
                {
                    if (bitCounts[bit] == 0)
                        result += (long)1 << bit;
                    bitCounts[bit]++;
                }
            }

            if (result < k)
                continue;

            while (i < j)
            {
                for (int bit = 0; bit < bitCounts.Length; bit++)
                {
                    if ((nums[i] & (long)1 << bit) > 0)
                    {
                        bitCounts[bit]--;
                        if (bitCounts[bit] == 0)
                            result -= (long)1 << bit;
                    }
                }

                if (result >= k)
                {
                    i++;
                    continue;
                }

                for (int bit = 0; bit < bitCounts.Length; bit++)
                {
                    if ((nums[i] & (long)1 << bit) > 0)
                    {
                        if (bitCounts[bit] == 0)
                            result += (long)1 << bit;
                        bitCounts[bit]++;
                    }
                }
                break;
            }

            if (j - i + 1 < minLength)
                minLength = j - i + 1;
        }

        if (minLength == nums.Length + 1)
            return -1;

        return minLength;
    }
}
