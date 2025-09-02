namespace LeetCode.T3001_T3500.T3101_T3200.T3197_FindTheMinimumAreaToCoverAllOnesII;

public class T_FindTheMinimumAreaToCoverAllOnesII
{
    private int MinimumArea(int[][] grid, int startI, int startJ, int endI, int endJ)
    {
        var left = endJ;
        var right = startJ;
        var top = endI;
        var bottom = startI;

        for (int i = startI; i < endI; i++)
        {
            for (int j = startJ; j < endJ; j++)
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

        var result = (right - left + 1) * (bottom - top + 1);

        if (result <= 0)
            return 0;

        return result;
    }

    public int MinimumSum(int[][] grid)
    {
        var min = int.MaxValue;

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[0].Length; j++)
            {
                var sum = MinimumArea(grid, 0, 0, i, grid[0].Length)
                    + MinimumArea(grid, i, 0, grid.Length, j)
                    + MinimumArea(grid, i, j, grid.Length, grid[0].Length);

                if (sum < min)
                    min = sum;
            }
        }

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[0].Length; j++)
            {
                var sum = MinimumArea(grid, 0, 0, i, j)
                    + MinimumArea(grid, 0, j, i, grid[0].Length)
                    + MinimumArea(grid, i, 0, grid.Length, grid[0].Length);

                if (sum < min)
                    min = sum;
            }
        }

        for (int i1 = 1; i1 < grid.Length - 1; i1++)
        {
            for (int i2 = i1 + 1; i2 < grid.Length; i2++)
            {
                var sum = MinimumArea(grid, 0, 0, i1, grid[0].Length)
                    + MinimumArea(grid, i1, 0, i2, grid[0].Length)
                    + MinimumArea(grid, i2, 0, grid.Length, grid[0].Length);

                if (sum < min)
                    min = sum;
            }
        }

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[0].Length; j++)
            {
                var sum = MinimumArea(grid, 0, 0, grid.Length, j)
                    + MinimumArea(grid, 0, j, i, grid[0].Length)
                    + MinimumArea(grid, i, j, grid.Length, grid[0].Length);

                if (sum < min)
                    min = sum;
            }
        }

        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[0].Length; j++)
            {
                var sum = MinimumArea(grid, 0, 0, i, j)
                    + MinimumArea(grid, i, 0, grid.Length, j)
                    + MinimumArea(grid, 0, j, grid.Length, grid[0].Length);

                if (sum < min)
                    min = sum;
            }
        }

        for (int j1 = 1; j1 < grid[0].Length - 1; j1++)
        {
            for (int j2 = j1 + 1; j2 < grid[0].Length; j2++)
            {
                var sum = MinimumArea(grid, 0, 0, grid.Length, j1)
                    + MinimumArea(grid, 0, j1, grid.Length, j2)
                    + MinimumArea(grid, 0, j2, grid.Length, grid[0].Length);

                if (sum < min)
                    min = sum;
            }
        }

        return min;
    }
}
