namespace LeetCode.T0001_T0500.T0001_T0100.T0037_SudokuSolver;

public class T_SudokuSolver
{
    const int Size = 9;
    bool _founded = false;

    public void SolveSudoku(char[][] board)
    {
        Backtracking(board, 0);
    }

    public void Backtracking(char[][] board, int index)
    {
        if (index >= Size * Size)
        {
            _founded = true;
            return;
        }

        int i = index / Size;
        int j = index % Size;

        if (board[i][j] != '.')
        {
            Backtracking(board, index + 1);
            return;
        }

        for (int number = 1; number <= 9; number++)
        {
            char charNumber = (char)('0' + number);
            var exists = false;
            for (int y = 0; y < Size; y++)
            {
                if (board[y][j] == charNumber)
                {
                    exists = true;
                    break;
                }
            }
            if (exists)
                continue;
            for (int x = 0; x < Size; x++)
            {
                if (board[i][x] == charNumber)
                {
                    exists = true;
                    break;
                }
            }
            if (exists)
                continue;

            var ySquareStart = (i / 3) * 3;
            var xSquareStart = (j / 3) * 3;
            for (int y = ySquareStart; y < ySquareStart + 3; y++)
            {
                for (int x = xSquareStart; x < xSquareStart + 3; x++)
                {
                    if (board[y][x] == charNumber)
                    {
                        exists = true;
                        break;
                    }
                }
                if (exists)
                    break;
            }
            if (exists)
                continue;

            board[i][j] = charNumber;
            Backtracking(board, index + 1);
            if (_founded)
                return;
        }

        board[i][j] = '.';
    }
}
