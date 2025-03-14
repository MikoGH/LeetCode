namespace LeetCode.T2501_T3000.T2901_T3000.T2924_FindChampionII;

public class T_FindChampionII
{
    public int FindChampion(int n, int[][] edges)
    {
        var nodes = edges.ToLookup(x => x[1], x => x[0]);
        var champion = -1;
        for (int node = 0; node < n; node++)
        {
            if (!nodes.Contains(node))
            {
                if (champion != -1)
                    return -1;
                champion = node;
            }
        }
        return champion;
    }
}
