namespace LeetCode.T2501_T3000.T2601_T2700.T2661_FirstCompletelyPaintedRowOrColumn;

public class T_FirstCompletelyPaintedRowOrColumn
{
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        var n = mat.Length;
        var m = mat[0].Length;
        var positions = new Dictionary<int, (int Y, int X)>(n * m);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                positions.Add(mat[i][j], (i, j));
            }
        }

        var rows = new int[n];
        var columns = new int[m];

        for (int i = 0; i < n * m; i++)
        {
            var position = positions[arr[i]];

            rows[position.Y]++;
            if (rows[position.Y] == m)
                return i;

            columns[position.X]++;
            if (columns[position.X] == n)
                return i;
        }

        return -1;
    }
}
