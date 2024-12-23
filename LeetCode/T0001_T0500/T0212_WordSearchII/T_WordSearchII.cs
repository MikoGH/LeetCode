namespace LeetCode.T0001_T0500.T0212_WordSearchII;

public class T_WordSearchII
{
    public class Node
    {
        public char Symbol {  get; set; }
        public Dictionary<char, Node> NextSymbols { get; set; } = new Dictionary<char, Node>();
        public int WordIndex = -1;

        public Node(char symbol)
        {
            Symbol = symbol;
        }
    }

    public bool[] existedWords;

    public IList<string> FindWords(char[][] board, string[] words)
    {
        var bor = new Node('^');
        for (int i = 0; i < words.Length; i++)
        {
            var node = bor;
            for (int j = 0; j < words[i].Length; j++)
            {
                if (!node.NextSymbols.ContainsKey(words[i][j]))
                    node.NextSymbols.Add(words[i][j], new Node(words[i][j]));
                
                node = node.NextSymbols[words[i][j]];
            }
            node.WordIndex = i;
        }

        existedWords = new bool[words.Length];
        var visited = new bool[board.Length][];
        for (int i = 0; i < visited.Length; i++)
            visited[i] = new bool[board[0].Length];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (bor.NextSymbols.ContainsKey(board[i][j]))
                    Dfs(board, i, j, bor.NextSymbols[board[i][j]], visited);
            }
        }

        var result = Enumerable.Range(0, words.Length)
            .Where(x => existedWords[x])
            .Select(x => words[x])
            .ToArray();

        return result;
    }

    public void Dfs(char[][] board, int i, int j, Node node, bool[][] visited)
    {
        if (visited[i][j])
            return;
        
        if (node.WordIndex != -1)
            existedWords[node.WordIndex] = true;

        visited[i][j] = true;

        if (i - 1 >= 0 && node.NextSymbols.ContainsKey(board[i - 1][j]))
            Dfs(board, i - 1, j, node.NextSymbols[board[i - 1][j]], visited);
        if (i + 1 < board.Length && node.NextSymbols.ContainsKey(board[i + 1][j]))
            Dfs(board, i + 1, j, node.NextSymbols[board[i + 1][j]], visited);
        if (j - 1 >= 0 && node.NextSymbols.ContainsKey(board[i][j - 1]))
            Dfs(board, i, j - 1, node.NextSymbols[board[i][j - 1]], visited);
        if (j + 1 < board[0].Length && node.NextSymbols.ContainsKey(board[i][j + 1]))
            Dfs(board, i, j + 1, node.NextSymbols[board[i][j + 1]], visited);

        visited[i][j] = false;
    }
}
