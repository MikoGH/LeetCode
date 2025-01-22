namespace LeetCode.T1501_T2000.T1765_MapOfHighestPeak;

public class T_MapOfHighestPeak
{
    public int[][] HighestPeak(int[][] isWater)
    {
        var queue = new Queue<(int Y, int X)>();
        var visited = new bool[isWater.Length][];

        for (int i = 0; i < isWater.Length; i++)
        {
            visited[i] = new bool[isWater[i].Length];
            for (int j = 0; j < isWater[i].Length; j++)
            {
                if (isWater[i][j] == 1)
                {
                    queue.Enqueue((i, j));
                    isWater[i][j] = 0;
                    visited[i][j] = true;
                }
            }
        }

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            if (cell.Y - 1 >= 0 && !visited[cell.Y - 1][cell.X])
            {
                isWater[cell.Y - 1][cell.X] = isWater[cell.Y][cell.X] + 1;
                visited[cell.Y - 1][cell.X] = true;
                queue.Enqueue((cell.Y - 1, cell.X));
            }
            if (cell.Y + 1 < isWater.Length && !visited[cell.Y + 1][cell.X])
            {
                isWater[cell.Y + 1][cell.X] = isWater[cell.Y][cell.X] + 1;
                visited[cell.Y + 1][cell.X] = true;
                queue.Enqueue((cell.Y + 1, cell.X));
            }
            if (cell.X - 1 >= 0 && !visited[cell.Y][cell.X - 1])
            {
                isWater[cell.Y][cell.X - 1] = isWater[cell.Y][cell.X] + 1;
                visited[cell.Y][cell.X - 1] = true;
                queue.Enqueue((cell.Y, cell.X - 1));
            }
            if (cell.X + 1 < isWater[0].Length && !visited[cell.Y][cell.X + 1])
            {
                isWater[cell.Y][cell.X + 1] = isWater[cell.Y][cell.X] + 1;
                visited[cell.Y][cell.X + 1] = true;
                queue.Enqueue((cell.Y, cell.X + 1));
            }
        }

        return isWater;
    }
}
