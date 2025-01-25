namespace LeetCode.T0501_T1000.T0802_FindEventualSafeStates;

public class T_FindEventualSafeStates
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        var unsafeNodes = new bool[graph.Length];
        var visited = new bool[graph.Length];
        var globalVisited = new bool[graph.Length];

        var result = new List<int>();
        for (int i = 0; i < graph.Length; i++)
        {
            if (!Dfs(graph, visited, globalVisited, unsafeNodes, i))
                result.Add(i);
        }

        return result;
    }

    public bool Dfs(int[][] graph, bool[] visited, bool[] globalVisited, bool[] unsafeNodes, int currentNode)
    {
        if (visited[currentNode])
        {
            unsafeNodes[currentNode] = true;
            return true;
        }

        if (globalVisited[currentNode])
        {
            return unsafeNodes[currentNode];
        }

        visited[currentNode] = true;

        var isUnsafe = false;
        for (int i = 0; i < graph[currentNode].Length; i++)
        {
            isUnsafe |= Dfs(graph, visited, globalVisited, unsafeNodes, graph[currentNode][i]);
        }

        unsafeNodes[currentNode] = isUnsafe;
        globalVisited[currentNode] = true;
        visited[currentNode] = false;

        return isUnsafe;
    }
}
