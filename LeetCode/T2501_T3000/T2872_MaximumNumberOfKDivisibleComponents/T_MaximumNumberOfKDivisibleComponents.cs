namespace LeetCode.T2501_T3000.T2872_MaximumNumberOfKDivisibleComponents;

public class T_MaximumNumberOfKDivisibleComponents
{
    public int Count;

    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        if (n == 1) return 1;

        var adjacent = edges
            .Select(x => new int[] { x[1], x[0] })
            .Concat(edges)
            .ToLookup(x => x[0], x => x[1]);

        GetSum(adjacent, values, 0, k);

        return Count;
    }

    private long GetSum(ILookup<int, int> adjacent, int[] values, int node, int k)
    {
        if (values[node] == -1)
            return 0;

        long sum = values[node];
        values[node] = -1;
        foreach (var adjacentNode in adjacent[node])
        {
            sum += GetSum(adjacent, values, adjacentNode, k);
        }

        if (sum % k == 0)
            Count++;

        return sum;
    }
}
