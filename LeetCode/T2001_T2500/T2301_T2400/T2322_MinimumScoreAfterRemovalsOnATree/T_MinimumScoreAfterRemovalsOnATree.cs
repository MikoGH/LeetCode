namespace LeetCode.T2001_T2500.T2301_T2400.T2322_MinimumScoreAfterRemovalsOnATree;

public class T_MinimumScoreAfterRemovalsOnATree
{
    private int _total = 0;
    private int _result = int.MaxValue;

    public int MinimumScore(int[] nums, int[][] edges)
    {
        var connections = edges
            .Concat(edges.Select(x => new int[] { x[1], x[0] }))
            .GroupBy(x => x[0], x => x[1])
            .ToDictionary(x => x.Key, x => x.ToList());

        foreach (var num in nums)
            _total ^= num;

        Dfs(nums, connections, -1, 0);

        return _result;
    }

    private int Dfs(int[] nums, Dictionary<int, List<int>> connections, int prev, int i)
    {
        var num = nums[i];

        foreach (var connection in connections[i])
        {
            if (connection == prev)
                continue;

            num ^= Dfs(nums, connections, i, connection);
        }

        foreach (var connection in connections[i])
        {
            if (connection == prev)
                Dfs2(nums, connections, i, connection, i, num);
        }

        return num;
    }

    private int Dfs2(int[] nums, Dictionary<int, List<int>> connections, int prev, int i, int prev2, int num2)
    {
        int num = nums[i];
        foreach (int connection in connections[i])
        {
            if (connection == prev)
                continue;
            num ^= Dfs2(nums, connections, i, connection, prev2, num2);
        }
        if (prev == prev2)
        {
            return num;
        }
        var part1 = num2;
        var part2 = num;
        var part3 = _total ^ num ^ num2;
        _result = Math.Min(_result, Math.Max(part1, Math.Max(part2, part3)) - Math.Min(part1, Math.Min(part2, part3)));

        return num;
    }
}
