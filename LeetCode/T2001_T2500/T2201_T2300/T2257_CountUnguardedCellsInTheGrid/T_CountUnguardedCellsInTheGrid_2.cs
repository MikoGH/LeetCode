namespace LeetCode.T2001_T2500.T2201_T2300.T2257_CountUnguardedCellsInTheGrid;

public class T_CountUnguardedCellsInTheGrid_2
{
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        byte[,] field = new byte[m, n];

        foreach (int[] wall in walls)
        {
            field[wall[0], wall[1]] = 3;
        }

        // 2 -vert, 3-hor
        foreach (int[] guard in guards)
        {
            int i = guard[0], j = guard[1];
            field[i, j] = 3;

            i = guard[0] - 1;
            while (i >= 0 && field[i, j] < 2)
                field[i--, j] = 2;

            i = guard[0] + 1;
            while (i < m && field[i, j] < 2)
                field[i++, j] = 2;

            i = guard[0];
            j = guard[1] - 1;
            while (j >= 0 && field[i, j] < 3 && field[i, j] != 1)
                field[i, j--] = 1;

            j = guard[1] + 1;
            while (j < n && field[i, j] < 3 && field[i, j] != 1)
                field[i, j++] = 1;
        }

        var count = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (field[i, j] == 0)
                    count++;
            }
        }

        return count;
    }
}
