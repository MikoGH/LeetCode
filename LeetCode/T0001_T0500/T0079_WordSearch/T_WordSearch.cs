namespace LeetCode.T0001_T0500.T0079_WordSearch;

public class T_WordSearch
{
    public bool Exist(char[][] board, string word)
    {
        var visited = new bool[board.Length][];
        for (int i = 0; i < visited.Length; i++)
            visited[i] = new bool[board[0].Length];

        var result = false;

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0] && !result)
                    result = Dfs(board, i, j, word, 0, visited);
            }
        }

        return result;
    }

    public bool Dfs(char[][] board, int i, int j, string word, int iWord, bool[][] visited)
    {
        if (visited[i][j])
            return false;

        if (word[iWord] != board[i][j])
            return false;

        if (iWord == word.Length - 1)
            return true;

        visited[i][j] = true;

        var result = false;

        if (i - 1 >= 0)
            result = Dfs(board, i - 1, j, word, iWord + 1, visited);
        if (i + 1 < board.Length && !result)
            result = Dfs(board, i + 1, j, word, iWord + 1, visited);
        if (j - 1 >= 0 && !result)
            result = Dfs(board, i, j - 1, word, iWord + 1, visited);
        if (j + 1 < board[0].Length && !result)
            result = Dfs(board, i, j + 1, word, iWord + 1, visited);

        visited[i][j] = false;

        return result;
    }
}
