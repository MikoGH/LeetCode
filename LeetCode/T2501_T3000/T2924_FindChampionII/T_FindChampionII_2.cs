namespace LeetCode.T2501_T3000.T2924_FindChampionII;

public class T_FindChampionII_2
{
    public int FindChampion(int n, int[][] edges)
    {
        var nodes = new byte[n];
        for (int i = 0; i < edges.Length; i++)
        {
            nodes[edges[i][1]] += 1;
        }
        var champion = -1;
        for (int i = 0; i < n; i++)
        {
            if (nodes[i] == 0)
            {
                if (champion != -1)
                    return -1;
                champion = i;
            }
        }
        return champion;
    }
}
