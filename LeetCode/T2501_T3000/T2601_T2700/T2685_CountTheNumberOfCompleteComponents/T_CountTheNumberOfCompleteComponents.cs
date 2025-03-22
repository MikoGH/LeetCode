namespace LeetCode.T2501_T3000.T2601_T2700.T2685_CountTheNumberOfCompleteComponents;

public class T_CountTheNumberOfCompleteComponents
{
    public int CountCompleteComponents(int n, int[][] edges)
    {
        var result = 0;

        var connections = edges
            .Concat(edges.Select(x => new int[] { x[1], x[0] }))
            .GroupBy(x => x[0], x => x[1])
            .ToDictionary(x => x.Key, x => x.ToList());

        var groupValues = new List<int>(2) { -1 };
        var group = 1;

        var nodeGroups = new int[n];

        var queue = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            if (nodeGroups[i] > 0)
                continue;

            var countEdges = 0;
            var countNodes = 0;
            queue.Enqueue(i);
            nodeGroups[i] = group;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                countNodes++;

                if (!connections.TryGetValue(node, out var connectedNodes))
                    continue;

                countEdges += connectedNodes.Count;

                foreach (var connectedNode in connectedNodes)
                {
                    if (nodeGroups[connectedNode] > 0)
                        continue;

                    queue.Enqueue(connectedNode);
                    nodeGroups[connectedNode] = group;
                }
            }

            if (countNodes * (countNodes - 1) == countEdges)
                result++;

            group++;
        }

        return result;
    }
}
