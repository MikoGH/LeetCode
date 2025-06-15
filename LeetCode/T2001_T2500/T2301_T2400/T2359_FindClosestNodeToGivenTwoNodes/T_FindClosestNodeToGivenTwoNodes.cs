namespace LeetCode.T2001_T2500.T2301_T2400.T2359_FindClosestNodeToGivenTwoNodes;

public class T_FindClosestNodeToGivenTwoNodes
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        if (node1 == node2)
            return node1;

        var visited = new int[edges.Length];

        var queue = new PriorityQueue<(int Depth, int Node, int StartNode), (int Depth, int Node)>();

        queue.Enqueue((0, node1, 1), (0, node1));
        queue.Enqueue((0, node2, 2), (0, node2));
        visited[node1] = 1;
        visited[node2] = 2;

        var result = -1;
        var resultDepth = -1;

        while (queue.Count > 0)
        {
            var (depth, node, startNode) = queue.Dequeue();

            if (resultDepth != -1 && depth != resultDepth)
                break;

            var connectedNode = edges[node];
            if (connectedNode == -1)
                continue;

            if (visited[connectedNode] == startNode)
                continue;

            if (visited[connectedNode] != 0)
            {
                if (resultDepth == -1 || result > connectedNode)
                {
                    result = connectedNode;
                    resultDepth = depth;
                }
                continue;
            }

            visited[connectedNode] = startNode;

            queue.Enqueue((depth + 1, connectedNode, startNode), (depth + 1, connectedNode));
        }

        return result;
    }
}

/*
0,1,2,3, 4,5,6,7,8,9
4,4,8,-1,9,8,4,4,1,1

0,5,1 0,6,2
0,6,2 1,8,1
1,4,2 1,8,1
1,8,1 2,9,2
2,4,1 2,9,2

*/
