namespace LeetCode.T3001_T3500.T3101_T3200.T3195_FindTheMinimumAreaToCoverAllOnesI;

public class T_FindTheMinimumAreaToCoverAllOnesI
{
    public int MinimumArea(int[][] grid)
    {
        var left = grid[0].Length;
        var right = 0;
        var top = grid.Length;
        var bottom = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 0)
                    continue;

                if (j < left)
                    left = j;
                if (j > right)
                    right = j;
                if (i < top)
                    top = i;
                if (i > bottom)
                    bottom = i;
            }
        }

        return (right - left + 1) * (bottom - top + 1);
    }
}
