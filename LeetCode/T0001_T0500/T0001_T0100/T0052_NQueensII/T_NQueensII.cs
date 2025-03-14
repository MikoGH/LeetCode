namespace LeetCode.T0001_T0500.T0001_T0100.T0052_NQueensII;

public class T_NQueensII
{
    bool[] diagonals1;
    bool[] diagonals2;
    bool[] rows;
    int count = 0;

    public int TotalNQueens(int n)
    {
        diagonals1 = new bool[n * 2];
        diagonals2 = new bool[n * 2];
        rows = new bool[n];

        GetQueenCount(0);

        return count;
    }

    private void GetQueenCount(int column)
    {
        if (column == rows.Length)
        {
            count++;
            return;
        }

        for (int row = 0; row < rows.Length; row++)
        {
            int diagonal1 = row + column;
            int diagonal2 = row + (rows.Length - column);

            if (diagonals1[diagonal1] || diagonals2[diagonal2] || rows[row])
                continue;

            diagonals1[diagonal1] = true;
            diagonals2[diagonal2] = true;
            rows[row] = true;
            GetQueenCount(column + 1);
            diagonals1[diagonal1] = false;
            diagonals2[diagonal2] = false;
            rows[row] = false;
        }
    }
}
