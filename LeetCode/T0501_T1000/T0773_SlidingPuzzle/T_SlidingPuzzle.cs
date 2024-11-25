using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode.T0501_T1000.T0773_SlidingPuzzle;

public class T_SlidingPuzzle
{
    int[][] _nextZeroPos = new int[6][]
    {
        new int[] { 1, 3 },
        new int[] { 0, 2, 4 },
        new int[] { 1, 5 },
        new int[] { 0, 4 },
        new int[] { 1, 3, 5 },
        new int[] { 2, 4 }
    };

    string _expected = "123450";

    public int SlidingPuzzle(int[][] board)
    {
        StringBuilder currentSb = new StringBuilder();
        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[i].Length; j++)
                currentSb = currentSb.Append(board[i][j]);

        string current = currentSb.ToString();

        var visited = new HashSet<string>();
        var queue = new Queue<(string, int)>();
        queue.Enqueue((current, 0));
        var saved = new List<string>();
        var prev = new List<int>();
        visited.Add(current);
        var countMoves = 0;
        while (queue.Count > 0)
        {
            (current, countMoves) = queue.Dequeue();

            if (current.Equals(_expected))
                return countMoves;

            var zeroPos = current.IndexOf('0');

            foreach (int nextZeroPos in _nextZeroPos[zeroPos])
            {
                StringBuilder nextSb = new StringBuilder(current);
                (nextSb[zeroPos], nextSb[nextZeroPos]) = (nextSb[nextZeroPos], nextSb[zeroPos]);
                string next = nextSb.ToString();

                if (visited.Contains(next))
                    continue;
                visited.Add(next);

                queue.Enqueue((next, countMoves + 1));
            }
        }

        return -1;
    }
}
