namespace LeetCode.T2501_T3000.T2965_FindMissingAndRepeatedValues;

public class T_FindMissingAndRepeatedValues
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var counts = new byte[grid.Length * grid.Length + 1];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                counts[grid[i][j]]++;
            }
        }

        var result = new int[2];
        for (int i = 1; i < counts.Length; i++)
        {
            if (counts[i] == 0)
                result[1] = i;
            if (counts[i] == 2)
                result[0] = i;
        }

        return result;
    }
}
