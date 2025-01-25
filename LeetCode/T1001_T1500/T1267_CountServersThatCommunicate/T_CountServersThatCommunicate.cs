namespace LeetCode.T1001_T1500.T1267_CountServersThatCommunicate;

public class T_CountServersThatCommunicate
{
    public int CountServers(int[][] grid)
    {
        var countByRows = new int[grid.Length];
        var count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                    countByRows[i]++;
            }
            if (countByRows[i] > 1)
                count += countByRows[i];
        }

        for (int j = 0; j < grid[0].Length; j++)
        {
            var countByColumn = 0;
            var countByColumnToAdd = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][j] == 1)
                {
                    countByColumn++;
                    if (countByRows[i] <= 1)
                    {
                        countByColumnToAdd++;
                    }
                }
            }
            if (countByColumn > 1)
                count += countByColumnToAdd;
        }

        return count;
    }
}
