namespace LeetCode.T2001_T2500.T2401_T2500.T2467_MostProfitablePathInATree;

public class T_MostProfitablePathInATree
{
    public int MostProfitablePath(int[][] edges, int bob, int[] amount)
    {
        var adjacentNodes = edges
            .Select(x => (x[0], x[1]))
            .Concat(edges.Select(x => (x[1], x[0])))
            .GroupBy(x => x.Item1, x => x.Item2)
            .ToDictionary(
                x => x.Key,
                x => x.ToList());
        var used = new bool[amount.Length];

        var (sum, _) = Dfs(adjacentNodes, amount, used, bob, 0, 1);

        return sum;
    }

    private (int Sum, double BobDepth) Dfs(Dictionary<int, List<int>> adjacentNodes, int[] amount, bool[] used, int bob, int node, int depth)
    {
        var nextSum = int.MinValue;
        double bobDepth = 0;

        used[node] = true;

        foreach (var adjacentNode in adjacentNodes[node])
        {
            if (used[adjacentNode])
                continue;

            var (nextSum2, bobDepth2) = Dfs(adjacentNodes, amount, used, bob, adjacentNode, depth + 1);
            if (nextSum2 > nextSum)
                nextSum = nextSum2;
            if (bobDepth2 > bobDepth)
                bobDepth = bobDepth2;
        }

        if (nextSum == int.MinValue)
            nextSum = 0;

        if (node == bob)
            bobDepth = (double)depth / 2;

        if (bobDepth <= 0)
            return (nextSum + amount[node], bobDepth - 1);
        if (bobDepth == 0.5)
            return (nextSum + amount[node] / 2, bobDepth - 1);
        return (nextSum, bobDepth - 1);
    }
}
