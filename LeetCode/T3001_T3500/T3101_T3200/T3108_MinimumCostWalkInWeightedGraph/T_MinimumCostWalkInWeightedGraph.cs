namespace LeetCode.T3001_T3500.T3101_T3200.T3108_MinimumCostWalkInWeightedGraph;

public class T_MinimumCostWalkInWeightedGraph
{
    public int[] MinimumCost(int n, int[][] edges, int[][] query)
    {
        var connections = edges
            .Concat(edges.Select(x => new int[] { x[1], x[0], x[2] }))
            .GroupBy(x => x[0], x => (x[1], x[2]))
            .ToDictionary(x => x.Key, x => x.ToList());

        var groupValues = new List<int>(1) { 0 };

        var nodeGroups = new int[n];

        var visited = new bool[n];

        var queue = new Queue<int>();

        var group = 1;

        for (int i = 0; i < n; i++)
        {
            if (visited[i])
                continue;

            queue.Enqueue(i);
            var groupValue = (int)Math.Pow(2, 30) - 1;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                visited[node] = true;
                nodeGroups[node] = group;

                if (!connections.ContainsKey(node))
                    continue;
                foreach (var edge in connections[node])
                {
                    groupValue &= edge.Item2;
                    if (!visited[edge.Item1])
                        queue.Enqueue(edge.Item1);
                }
            }

            groupValues.Add(groupValue);
            group++;
        }

        var result = new int[query.Length];
        for (int i = 0; i < query.Length; i++)
        {
            var group1 = nodeGroups[query[i][0]];
            var group2 = nodeGroups[query[i][1]];

            if (group1 != group2)
            {
                result[i] = -1;
                continue;
            }

            result[i] = groupValues[group1];
        }

        return result;
    }
}

/*
[[42,13,57271],[68,21,57343],[51,75,48041],[51,77,48956],[32,75,46970],[32,75,62329],[77,45,47018],[77,75,62248],[75,32,46058],
[51,77,63481],[45,51,62319],[77,32,46009],[32,51,63484],[45,75,63353],[32,51,62271],[51,32,63466],[77,51,64383],[45,32,62446],
[45,32,65405],[77,51,65337],[75,32,65391],[6,35,95967],[7,6,97751],[56,40,79599],[6,76,95991],[41,16,81919],[78,52,81879],
[55,37,65503],[70,63,49055],[37,70,44975],[55,70,59327],[19,66,65199],[64,29,64399],[34,30,84478],[57,50,93610],[25,59,53173]]
 * */
