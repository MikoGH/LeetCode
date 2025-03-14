namespace LeetCode.T0501_T1000.T0601_T0700.T0684_RedundantConnection;

public class T_RedundantConnection
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        var adjacent = edges
            .Concat(edges.Select(x => new int[] { x[1], x[0] }))
            .ToLookup(x => x[0], x => x[1])
            .ToDictionary(x => x.Key, x => x.ToArray());

        var visited = new bool[edges.Length + 1];

        Dfs(adjacent, visited, 1, -1);

        var result = new int[2];
        for (int i = 0; i < edges.Length; i++)
        {
            if (visited[edges[i][0]] && visited[edges[i][1]])
                result = edges[i];
        }

        return result;
    }

    private int Dfs(Dictionary<int, int[]> adjacent, bool[] visited, int currentNode, int previousNode)
    {
        if (visited[currentNode])
            return currentNode;

        visited[currentNode] = true;

        for (int i = 0; i < adjacent[currentNode].Length; i++)
        {
            if (adjacent[currentNode][i] == previousNode)
                continue;

            var result = Dfs(adjacent, visited, adjacent[currentNode][i], currentNode);

            if (result == currentNode)
                return -1;

            if (result != -1)
                return result;
        }

        visited[currentNode] = false;

        return -1;
    }
}
