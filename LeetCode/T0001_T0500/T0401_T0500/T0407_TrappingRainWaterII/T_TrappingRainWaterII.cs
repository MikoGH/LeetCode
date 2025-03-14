namespace LeetCode.T0001_T0500.T0401_T0500.T0407_TrappingRainWaterII;

public class T_TrappingRainWaterII
{
    public int TrapRainWater(int[][] heightMap)
    {
        var visited = new bool[heightMap.Length][];
        var heap = new PriorityQueue<(int Y, int X), int>();
        var n = heightMap.Length;
        var m = heightMap[0].Length;

        for (int y = 0; y < n; y++)
        {
            visited[y] = new bool[m];

            heap.Enqueue((y, 0), heightMap[y][0]);
            visited[y][0] = true;
            heap.Enqueue((y, m - 1), heightMap[y][m - 1]);
            visited[y][m - 1] = true;
        }
        for (int x = 1; x < m - 1; x++)
        {
            heap.Enqueue((0, x), heightMap[0][x]);
            visited[0][x] = true;
            heap.Enqueue((n - 1, x), heightMap[n - 1][x]);
            visited[n - 1][x] = true;
        }

        var result = 0;

        while (heap.Count > 0)
        {
            var cell = heap.Dequeue();

            if (cell.Y - 1 >= 0 && !visited[cell.Y - 1][cell.X])
            {
                visited[cell.Y - 1][cell.X] = true;
                if (heightMap[cell.Y][cell.X] > heightMap[cell.Y - 1][cell.X])
                {
                    result += heightMap[cell.Y][cell.X] - heightMap[cell.Y - 1][cell.X];
                    heightMap[cell.Y - 1][cell.X] = heightMap[cell.Y][cell.X];
                }
                heap.Enqueue((cell.Y - 1, cell.X), heightMap[cell.Y - 1][cell.X]);
            }
            if (cell.Y + 1 < n && !visited[cell.Y + 1][cell.X])
            {
                visited[cell.Y + 1][cell.X] = true;
                if (heightMap[cell.Y][cell.X] > heightMap[cell.Y + 1][cell.X])
                {
                    result += heightMap[cell.Y][cell.X] - heightMap[cell.Y + 1][cell.X];
                    heightMap[cell.Y + 1][cell.X] = heightMap[cell.Y][cell.X];
                }
                heap.Enqueue((cell.Y + 1, cell.X), heightMap[cell.Y + 1][cell.X]);
            }
            if (cell.X - 1 >= 0 && !visited[cell.Y][cell.X - 1])
            {
                visited[cell.Y][cell.X - 1] = true;
                if (heightMap[cell.Y][cell.X] > heightMap[cell.Y][cell.X - 1])
                {
                    result += heightMap[cell.Y][cell.X] - heightMap[cell.Y][cell.X - 1];
                    heightMap[cell.Y][cell.X - 1] = heightMap[cell.Y][cell.X];
                }
                heap.Enqueue((cell.Y, cell.X - 1), heightMap[cell.Y][cell.X - 1]);
            }
            if (cell.X + 1 < m && !visited[cell.Y][cell.X + 1])
            {
                visited[cell.Y][cell.X + 1] = true;
                if (heightMap[cell.Y][cell.X] > heightMap[cell.Y][cell.X + 1])
                {
                    result += heightMap[cell.Y][cell.X] - heightMap[cell.Y][cell.X + 1];
                    heightMap[cell.Y][cell.X + 1] = heightMap[cell.Y][cell.X];
                }
                heap.Enqueue((cell.Y, cell.X + 1), heightMap[cell.Y][cell.X + 1]);
            }
        }

        return result;
    }
}
