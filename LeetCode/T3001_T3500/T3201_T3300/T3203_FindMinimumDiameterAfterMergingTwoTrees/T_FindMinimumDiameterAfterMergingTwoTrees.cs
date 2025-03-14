namespace LeetCode.T3001_T3500.T3201_T3300.T3203_FindMinimumDiameterAfterMergingTwoTrees;

public class T_FindMinimumDiameterAfterMergingTwoTrees
{
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
    {
        var adjacentNodes1 = edges1
            .Select(x => new int[] { x[1], x[0] })
            .Concat(edges1)
            .ToLookup(x => x[0], x => x[1]);

        var adjacentNodes2 = edges2
            .Select(x => new int[] { x[1], x[0] })
            .Concat(edges2)
            .ToLookup(x => x[0], x => x[1]);

        var (_, maxDepthNode1) = Dfs(adjacentNodes1, 0, -1);
        var (maxDepth1, _) = Dfs(adjacentNodes1, maxDepthNode1, -1);

        var (_, maxDepthNode2) = Dfs(adjacentNodes2, 0, -1);
        var (maxDepth2, _) = Dfs(adjacentNodes2, maxDepthNode2, -1);

        var result = (int)Math.Ceiling((double)maxDepth1 / 2) + (int)Math.Ceiling((double)maxDepth2 / 2) + 1;

        if (maxDepth1 > result)
            result = maxDepth1;
        if (maxDepth2 > result)
            result = maxDepth2;

        return result;
    }

    public (int, int) Dfs(ILookup<int, int> adjacentNodes, int node, int prevNode)
    {
        var maxDepth = -1;
        var maxDepthNode = node;

        foreach (var adjacentNode in adjacentNodes[node])
        {
            if (adjacentNode == prevNode)
                continue;

            var (depth, depthNode) = Dfs(adjacentNodes, adjacentNode, node);
            if (depth > maxDepth)
            {
                maxDepth = depth;
                maxDepthNode = depthNode;
            }
        }

        return (maxDepth + 1, maxDepthNode);
    }
}
