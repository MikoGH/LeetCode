namespace LeetCode.T0501_T1000.T0501_T0600.T0542_01Matrix;

public class T_01Matrix
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        var queue = new Queue<(int Y, int X)>();
        var visited = new bool[mat.Length][];

        for (int i = 0; i < mat.Length; i++)
        {
            visited[i] = new bool[mat[i].Length];
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue((i, j));
                    visited[i][j] = true;
                }
            }
        }

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            if (cell.Y - 1 >= 0 && !visited[cell.Y - 1][cell.X])
            {
                mat[cell.Y - 1][cell.X] = mat[cell.Y][cell.X] + 1;
                visited[cell.Y - 1][cell.X] = true;
                queue.Enqueue((cell.Y - 1, cell.X));
            }
            if (cell.Y + 1 < mat.Length && !visited[cell.Y + 1][cell.X])
            {
                mat[cell.Y + 1][cell.X] = mat[cell.Y][cell.X] + 1;
                visited[cell.Y + 1][cell.X] = true;
                queue.Enqueue((cell.Y + 1, cell.X));
            }
            if (cell.X - 1 >= 0 && !visited[cell.Y][cell.X - 1])
            {
                mat[cell.Y][cell.X - 1] = mat[cell.Y][cell.X] + 1;
                visited[cell.Y][cell.X - 1] = true;
                queue.Enqueue((cell.Y, cell.X - 1));
            }
            if (cell.X + 1 < mat[0].Length && !visited[cell.Y][cell.X + 1])
            {
                mat[cell.Y][cell.X + 1] = mat[cell.Y][cell.X] + 1;
                visited[cell.Y][cell.X + 1] = true;
                queue.Enqueue((cell.Y, cell.X + 1));
            }
        }

        return mat;
    }
}
