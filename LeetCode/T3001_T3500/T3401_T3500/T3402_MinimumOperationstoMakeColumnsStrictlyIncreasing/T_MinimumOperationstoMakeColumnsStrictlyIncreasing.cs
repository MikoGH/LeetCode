namespace LeetCode.T3001_T3500.T3401_T3500.T3402_MinimumOperationstoMakeColumnsStrictlyIncreasing;

public class T_MinimumOperationstoMakeColumnsStrictlyIncreasing
{
    public int MinimumOperations(int[][] grid)
    {
        var result = 0;
        for (int j = 0; j < grid[0].Length; j++)
        {
            for (int i = 1; i < grid.Length; i++)
            {
                if (grid[i][j] <= grid[i - 1][j])
                {
                    result += grid[i - 1][j] - grid[i][j] + 1;
                    grid[i][j] = grid[i - 1][j] + 1;
                }
            }
        }

        return result;
    }
}
