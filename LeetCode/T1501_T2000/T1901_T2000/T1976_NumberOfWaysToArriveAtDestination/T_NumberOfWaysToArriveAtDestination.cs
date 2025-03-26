namespace LeetCode.T1501_T2000.T1901_T2000.T1976_NumberOfWaysToArriveAtDestination;

public class T_NumberOfWaysToArriveAtDestination
{
    public int CountPaths(int n, int[][] roads)
    {
        if (n == 1) return 1;

        int mod = (int)1e9 + 7;

        var connections = roads
            .Concat(roads.Select(x => new int[] { x[1], x[0], x[2] }))
            .GroupBy(x => x[0], x => (x[1], x[2]))
            .ToDictionary(x => x.Key, x => x.ToList());

        var visited = new bool[n];
        var countPaths = new int[n];
        var minDistances = new long[n];
        Array.Fill(minDistances, long.MaxValue);

        countPaths[0] = 1;
        minDistances[0] = 0;
        var count = 0;

        while (count < n)
        {
            count++;

            var node = -1;
            for (var i = 0; i < n; i++)
            {
                if (!visited[i] && (node == -1 || minDistances[i] < minDistances[node]))
                    node = i;
            }
            visited[node] = true;

            foreach (var connection in connections[node])
            {
                var connectedNode = connection.Item1;
                var edge = connection.Item2;

                if (visited[connectedNode])
                    continue;

                var distance = minDistances[node] + edge;

                if (minDistances[connectedNode] == distance)
                {
                    countPaths[connectedNode] = (countPaths[connectedNode] + countPaths[node]) % mod;
                    continue;
                }
                if (minDistances[connectedNode] < distance)
                {
                    continue;
                }

                minDistances[connectedNode] = distance;
                countPaths[connectedNode] = countPaths[node];
            }
        }

        return countPaths[n - 1];
    }
}
