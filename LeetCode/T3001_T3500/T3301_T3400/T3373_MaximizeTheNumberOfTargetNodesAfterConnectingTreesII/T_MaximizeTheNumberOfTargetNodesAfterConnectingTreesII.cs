namespace LeetCode.T3001_T3500.T3301_T3400.T3373_MaximizeTheNumberOfTargetNodesAfterConnectingTreesII;

public class T_MaximizeTheNumberOfTargetNodesAfterConnectingTreesII
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
    {
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

        var isEvenNodes1 = new bool[n];
        var isEvenNodes2 = new bool[m];

        var countEven1 = Dfs(connections1, visited1, isEvenNodes1, 0, true);
        var countOdd1 = n - countEven1;
        var countEven2 = Dfs(connections2, visited2, isEvenNodes2, 0, true);
        var countOdd2 = m - countEven2;

        var maxCount2 = Math.Max(countOdd2, countEven2);

        var result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = maxCount2 + (isEvenNodes1[i] ? countEven1 : countOdd1);
        }

        return result;
    }

    private int Dfs(Dictionary<int, int[]> connections, bool[] visited, bool[] isEvenNodes, int node, bool isEven)
    {
        visited[node] = true;

        isEvenNodes[node] = isEven;
        var sum = isEven ? 1 : 0;
        foreach (var connectedNode in connections[node])
        {
            if (visited[connectedNode])
                continue;

            sum += Dfs(connections, visited, isEvenNodes, connectedNode, !isEven);
        }

        return sum;
    }
}
