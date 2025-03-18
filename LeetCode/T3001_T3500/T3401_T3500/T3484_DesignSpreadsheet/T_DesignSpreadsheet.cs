namespace LeetCode.T3001_T3500.T3401_T3500.T3484_DesignSpreadsheet;

public class T_DesignSpreadsheet
{
    public class Spreadsheet
    {
        int[][] grid;

        public Spreadsheet(int rows)
        {
            grid = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                grid[i] = new int[26];
            }
        }

        public void SetCell(string cell, int value)
        {
            int col = cell[0] - 'A';
            int row = int.Parse(cell.Substring(1));
            grid[row][col] = value;
        }

        public void ResetCell(string cell)
        {
            int col = cell[0] - 'A';
            int row = int.Parse(cell.Substring(1));
            grid[row][col] = 0;
        }

        public int GetValue(string formula)
        {
            var elms = formula.Split('+');
            var value1 = 0;
            if ('A' <= elms[0][1] && elms[0][1] <= 'Z')
            {
                int col1 = elms[0][1] - 'A';
                int row1 = int.Parse(elms[0].Substring(2));
                if (col1 < grid[0].Length && row1 < grid.Length)
                    value1 = grid[row1][col1];
            }
            else
            {
                value1 = int.Parse(elms[0].Substring(1));
            }

            var value2 = 0;
            if ('A' <= elms[1][0] && elms[1][0] <= 'Z')
            {
                int col2 = elms[1][0] - 'A';
                int row2 = int.Parse(elms[1].Substring(1));
                if (col2 < grid[0].Length && row2 < grid.Length)
                    value2 = grid[row2][col2];
            }
            else
            {
                value2 = int.Parse(elms[1]);
            }

            return value1 + value2;
        }
    }
}
