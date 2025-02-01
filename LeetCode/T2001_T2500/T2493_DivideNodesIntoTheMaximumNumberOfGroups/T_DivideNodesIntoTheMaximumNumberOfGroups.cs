namespace LeetCode.T2001_T2500.T2493_DivideNodesIntoTheMaximumNumberOfGroups;

public class T_DivideNodesIntoTheMaximumNumberOfGroups
{
    public int MagnificentSets(int n, int[][] edges)
    {
        var adjacent = edges
            .Concat(edges.Select(x => new int[] { x[1], x[0] }))
            .ToLookup(x => x[0], x => x[1])
            .ToDictionary(x => x.Key, x => x.ToArray());

        var distances = new int[n + 1];
        var result = 0;
        var maxDistance = 0;
        var sums = new int[n + 1];

        var queue = new Queue<int>();
        for (int j = 1; j < n + 1; j++)
        {
            if (!adjacent.ContainsKey(j))
            {
                result++;
                continue;
            }

            distances[j] = 1;
            queue.Enqueue(j);
            var minNode = int.MaxValue;
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode < minNode)
                    minNode = currentNode;
                for (int i = 0; i < adjacent[currentNode].Length; i++)
                {
                    var adjacentNode = adjacent[currentNode][i];
                    if (distances[adjacentNode] == 0)
                    {
                        queue.Enqueue(adjacentNode);
                        distances[adjacentNode] = distances[currentNode] + 1;
                        if (distances[adjacentNode] > maxDistance)
                        {
                            maxDistance = distances[adjacentNode];
                        }
                        continue;
                    }
                    if (distances[adjacentNode] % 2 == distances[currentNode] % 2)
                        return -1;
                }
            }

            Array.Clear(distances);

            //result += maxDistance;
            if (sums[minNode] < maxDistance)
                sums[minNode] = maxDistance;
        }

        result += sums.Sum();

        return result;
    }
}
