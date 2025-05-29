namespace LeetCode.T3001_T3500.T3301_T3400.T3372_MaximizeTheNumberOfTargetNodesAfterConnectingTreesI;

public class T_MaximizeTheNumberOfTargetNodesAfterConnectingTreesI
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        if (k == 0)
        {
            var res = new int[edges1.Length + 1];
            Array.Fill(res, 1);
            return res;
        }

        var n = edges1.Length + 1;
        var connections1 = edges1
            .Concat(edges1.Select(x => new int[] { x[1], x[0] }))
            .GroupBy(x => x[0], x => x[1])
            .ToDictionary(x => x.Key, x => x.ToArray());

        var m = edges2.Length + 1;
        var connections2 = edges2
            .Concat(edges2.Select(x => new int[] { x[1], x[0] }))
            .GroupBy(x => x[0], x => x[1])
            .ToDictionary(x => x.Key, x => x.ToArray());

        var visited1 = new bool[n];
        var visited2 = new bool[m];

        var maxCount = 0;
        for (int node = 0; node < m; node++)
        {
            var count = Dfs(connections2, visited2, node, 0, k - 1);
            Array.Clear(visited2);
            if (count > maxCount)
                maxCount = count;
        }

        var result = new int[n];

        for (int node = 0; node < n; node++)
        {
            var count = Dfs(connections1, visited1, node, 0, k);
            Array.Clear(visited1);

            result[node] = count + maxCount;
        }

        return result;
    }

    private int Dfs(Dictionary<int, int[]> connections, bool[] visited, int node, int depth, int k)
    {
        visited[node] = true;

        if (depth >= k)
            return 1;

        var sum = 1;
        foreach (var connectedNode in connections[node])
        {
            if (visited[connectedNode])
                continue;

            sum += Dfs(connections, visited, connectedNode, depth + 1, k);
        }

        return sum;
    }
}
