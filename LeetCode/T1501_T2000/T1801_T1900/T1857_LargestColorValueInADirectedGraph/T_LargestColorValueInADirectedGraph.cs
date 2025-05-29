namespace LeetCode.T1501_T2000.T1801_T1900.T1857_LargestColorValueInADirectedGraph;

public class T_LargestColorValueInADirectedGraph
{
    public int LargestPathValue(string colors, int[][] edges)
    {
        //if (edges.Length == 0)
        //{
        //    return 1;
        //}

        //var connections = edges.ToLookup(x => x[0], x => x[1]).ToDictionary(x => x.Key, x => x);

        //var letters = new int[colors.Length][];
        //for (int i = 0; i < letters.Length; i++)
        //    letters[i] = new int[26];

        //var countVisited = new int[colors.Length];

        //var startNodes = new bool[colors.Length];
        //Array.Fill(startNodes, true);

        //var countIn = new int[colors.Length];
        //foreach (var edge in edges)
        //{
        //    countIn[edge[1]]++;
        //    startNodes[edge[1]] = false;
        //}

        //var queue = new Queue<int>();
        //var visited = new bool[colors.Length];

        //for (int i = 0; i < startNodes.Length; i++)
        //{
        //    if (!startNodes[i])
        //        continue;

        //    visited[i] = true;
        //    queue.Enqueue(i);
        //    letters[i][colors[i] - 'a']++;
        //}

        //if (queue.Count == 0)
        //    return -1;

        //var result = 0;

        //while (queue.Count > 0)
        //{
        //    var node = queue.Dequeue();

        //    countIn[node]--;
        //    if (countIn[node] > 0)
        //    {
        //        queue.Enqueue(node);
        //        continue;
        //    }

        //    if (!connections.ContainsKey(node))
        //    {
        //        continue;
        //    }

        //    foreach (var connectedNode in connections[node])
        //    {
        //        countVisited[connectedNode]++;
        //        if (visited[connectedNode])
        //        {
        //            if (countVisited[connectedNode] > colors.Length)
        //                return -1;

        //            for (int i = 0; i < letters[connectedNode].Length; i++)
        //            {
        //                if (letters[connectedNode][i] <= letters[node][i])
        //                {
        //                    letters[connectedNode][i] = letters[node][i];
        //                    if (i == colors[connectedNode] - 'a')
        //                        letters[connectedNode][i]++;
        //                    result = Math.Max(result, letters[connectedNode][i]);
        //                }
        //            }
        //            continue;
        //        }

        //        visited[connectedNode] = true;
        //        queue.Enqueue(connectedNode);

        //        for (int i = 0; i < letters[connectedNode].Length; i++)
        //        {
        //            letters[connectedNode][i] = letters[node][i];
        //            if (i == colors[connectedNode] - 'a')
        //                letters[connectedNode][i]++;
        //            result = Math.Max(result, letters[connectedNode][i]);
        //        }
        //    }
        //}

        //return result;

        int n = colors.Length;

        var countIn = new int[n];

        var connections = edges.ToLookup(x => x[0], x => x[1]).ToDictionary(x => x.Key, x => x);

        foreach (var edge in edges)
        {
            countIn[edge[1]]++;
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (countIn[i] == 0)
                queue.Enqueue(i);
        }

        int[,] count = new int[n, 26];
        int visited = 0;
        int result = 0;

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            visited++;
            int colorIndex = colors[node] - 'a';
            count[node, colorIndex]++;
            result = Math.Max(result, count[node, colorIndex]);

            if (!connections.ContainsKey(node))
                continue;

            foreach (int connectedNode in connections[node])
            {
                for (int i = 0; i < 26; i++)
                {
                    count[connectedNode, i] = Math.Max(count[connectedNode, i], count[node, i]);
                }

                countIn[connectedNode]--;
                if (countIn[connectedNode] == 0)
                    queue.Enqueue(connectedNode);
            }
        }

        return visited == n ? result : -1;
    }
}
