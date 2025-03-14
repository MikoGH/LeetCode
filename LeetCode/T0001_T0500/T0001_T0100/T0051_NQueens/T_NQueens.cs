namespace LeetCode.T0001_T0500.T0001_T0100.T0051_NQueens;

public class T_NQueens
{
    bool[] diagonals1;
    bool[] diagonals2;
    int[] rows;
    List<string> rowsStrings;
    List<string[]> result = new List<string[]>();

    public IList<IList<string>> SolveNQueens(int n)
    {
        diagonals1 = new bool[n * 2];
        diagonals2 = new bool[n * 2];
        rows = new int[n];

        rowsStrings = new List<string>(n);
        var chars = new char[n];
        for (int i = 0; i < n; i++)
        {
            chars[i] = '.';
            rows[i] = -1;
        }
        for (int i = 0; i < n; i++)
        {
            chars[i] = 'Q';
            if (i > 0)
                chars[i - 1] = '.';
            rowsStrings.Add(new string(chars));
        }

        GetQueenPositions(0);

        return result.ToArray();
    }

    private void GetQueenPositions(int column)
    {
        if (column == rows.Length)
        {
            var res = new string[rows.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                res[i] = rowsStrings[rows[i]];
            }
            result.Add(res);
            return;
        }

        for (int row = 0; row < rows.Length; row++)
        {
            int diagonal1 = row + column;
            int diagonal2 = row + (rows.Length - column);

            if (diagonals1[diagonal1] || diagonals2[diagonal2] || rows[row] >= 0)
                continue;

            diagonals1[diagonal1] = true;
            diagonals2[diagonal2] = true;
            rows[row] = column;
            GetQueenPositions(column + 1);
            diagonals1[diagonal1] = false;
            diagonals2[diagonal2] = false;
            rows[row] = -1;
        }
    }
}
