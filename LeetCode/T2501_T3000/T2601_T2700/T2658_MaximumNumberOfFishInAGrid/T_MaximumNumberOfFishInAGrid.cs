namespace LeetCode.T2501_T3000.T2601_T2700.T2658_MaximumNumberOfFishInAGrid;

public class T_MaximumNumberOfFishInAGrid
{
    public int FindMaxFish(int[][] grid)
    {
        var result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }
                var sum = Dfs(grid, i, j);
                if (sum > result)
                {
                    result = sum;
                }
            }
        }

        return result;
    }

    public int Dfs(int[][] grid, int y, int x)
    {
        var sum = grid[y][x];
        grid[y][x] = 0;

        if (y - 1 >= 0 && grid[y - 1][x] > 0)
        {
            sum += Dfs(grid, y - 1, x);
        }

        if (y + 1 < grid.Length && grid[y + 1][x] > 0)
        {
            sum += Dfs(grid, y + 1, x);
        }

        if (x - 1 >= 0 && grid[y][x - 1] > 0)
        {
            sum += Dfs(grid, y, x - 1);
        }

        if (x + 1 < grid[0].Length && grid[y][x + 1] > 0)
        {
            sum += Dfs(grid, y, x + 1);
        }

        return sum;
    }
}
