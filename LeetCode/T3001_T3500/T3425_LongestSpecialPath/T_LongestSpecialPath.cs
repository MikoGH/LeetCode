namespace LeetCode.T3001_T3500.T3425_LongestSpecialPath;

public class T_LongestSpecialPath
{
    public int MaxLength { get; set; } = 0;
    public int MinNodes { get; set; } = 1;
    public int[] LongestSpecialPath(int[][] edges, int[] nums)
    {
        var connections = new Dictionary<int, List<(int Node, int Value)>>();

        for (int i = 0; i < edges.Length; i++)
        {
            if (!connections.ContainsKey(edges[i][0]))
                connections.Add(edges[i][0], new List<(int Node, int Value)>());
            connections[edges[i][0]].Add((edges[i][1], edges[i][2]));
            if (!connections.ContainsKey(edges[i][1]))
                connections.Add(edges[i][1], new List<(int Node, int Value)>());
            connections[edges[i][1]].Add((edges[i][0], edges[i][2]));
        }

        var countCompleted = new int[edges.Length + 1];

        var unique = new bool[5 * (int)1e4 + 1];
        var visited = new bool[edges.Length + 1];
        var queue = new Queue<int>();
        queue.Enqueue(0);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            unique[nums[node]] = true;
            visited[node] = true;
            Dfs(nums, connections, unique, visited, countCompleted, node, 0, 1);
            unique[nums[node]] = false;

            foreach (var nextNode in connections[node])
                if (!visited[nextNode.Node])
                    queue.Enqueue(nextNode.Node);
        }

        return new int[] { MaxLength, MinNodes };
    }

    private void Dfs(int[] nums, Dictionary<int, List<(int Node, int Value)>> connections, bool[] unique, bool[] visited, int[] countCompleted, int currentNode, int currentLength, int countNodes)
    {
        if (currentLength > MaxLength)
        {
            MaxLength = currentLength;
            MinNodes = countNodes;
        }
        else if (currentLength == MaxLength && countNodes < MinNodes)
        {
            MinNodes = countNodes;
        }

        if (!connections.ContainsKey(currentNode))
        {
            countCompleted[currentNode] = -1;
            foreach (var node in connections[currentNode])
                if (countCompleted[node.Node] != -1)
                    countCompleted[node.Node]++;
            return;
        }

        foreach (var values in connections[currentNode])
        {
            if (unique[nums[values.Node]] || visited[values.Node])
                continue;

            unique[nums[values.Node]] = true;
            visited[values.Node] = true;
            Dfs(nums, connections, unique, visited, countCompleted, values.Node, currentLength + values.Value, countNodes + 1);
            unique[nums[values.Node]] = false;
            visited[values.Node] = false;

            if (countCompleted[currentNode] == connections[currentNode].Count - 1)
            {
                countCompleted[currentNode] = -1;
                foreach (var node in connections[currentNode])
                    if (countCompleted[node.Node] != -1)
                        countCompleted[node.Node]++;
            }

        }
    }
}
