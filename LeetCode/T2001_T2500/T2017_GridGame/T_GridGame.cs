namespace LeetCode.T2001_T2500.T2017_GridGame;

public class T_GridGame
{
    public long GridGame(int[][] grid)
    {
        long sum0 = grid[0][^1];
        long sum1 = grid[1][^1];
        long total1 = 0;

        for (int i = grid[1].Length - 1; i >= 0; i--)
        {
            total1 += grid[1][i];
        }

        long result = total1 - grid[1][^1];
        for (int i = grid[0].Length - 2; i >= 0; i--)
        {
            sum1 += grid[1][i];
            result = Math.Min(Math.Max(sum0, total1 - sum1), result);
            sum0 += grid[0][i];
        }

        return result;
    }
}
