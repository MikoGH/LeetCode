namespace LeetCode.T2501_T3000.T2901_T3000.T2929_DistributeCandiesAmongChildrenII;

public class T_DistributeCandiesAmongChildrenII
{
    public long DistributeCandies(int n, int limit)
    {
        if (n > limit * 3)
            return 0;

        long result = 0;

        var minI = Math.Max(0, n - 2 * limit);
        var maxI = Math.Min(limit, n);

        for (int i = minI; i <= maxI; i++)
        {
            var nLeft = n - i;
            result += Math.Min(limit, nLeft) - Math.Max(0, nLeft - limit);
        }

        return result;
    }
}
