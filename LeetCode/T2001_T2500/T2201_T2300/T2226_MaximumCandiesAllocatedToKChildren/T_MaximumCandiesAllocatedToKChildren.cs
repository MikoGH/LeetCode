namespace LeetCode.T2001_T2500.T2201_T2300.T2226_MaximumCandiesAllocatedToKChildren;

public class T_MaximumCandiesAllocatedToKChildren
{
    public int MaximumCandies(int[] candies, long k)
    {
        int l = 0;
        int r = candies.Max();

        while (l + 1 < r)
        {
            var s = l + r >> 1;
            if (Check(candies, k, s))
                l = s;
            else
                r = s;
        }

        return l;
    }

    private bool Check(int[] candies, long k, int s)
    {
        long count = 0;

        for (var i = 0; i < candies.Length; i++)
        {
            count += candies[i] / s;
        }

        return count >= k;
    }
}
