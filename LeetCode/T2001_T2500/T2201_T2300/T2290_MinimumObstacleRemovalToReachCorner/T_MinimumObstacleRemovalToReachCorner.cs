namespace LeetCode.T2001_T2500.T2201_T2300.T2290_MinimumObstacleRemovalToReachCorner;

public class T_MinimumObstacleRemovalToReachCorner
{
    public int MinimumObstacles(int[][] grid)
    {
        int[][] field = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            field[i] = Enumerable.Repeat(int.MaxValue, grid[i].Length).ToArray();
        }

        field[0][0] = 0;
        var nextPos = new Queue<(int Y, int X, int Distance)>(1);
        nextPos.Enqueue((0, 0, 0));

        while (nextPos.Count > 0)
        {
            var pos = nextPos.Peek();
            nextPos.Dequeue();

            if (pos.Distance > field[pos.Y][pos.X])
                continue;

            if (pos.Y - 1 >= 0 && field[pos.Y][pos.X] + grid[pos.Y - 1][pos.X] < field[pos.Y - 1][pos.X])
            {
                field[pos.Y - 1][pos.X] = field[pos.Y][pos.X] + grid[pos.Y - 1][pos.X];
                nextPos.Enqueue((pos.Y - 1, pos.X, field[pos.Y - 1][pos.X]));
            }
            if (pos.Y + 1 < field.Length && field[pos.Y][pos.X] + grid[pos.Y + 1][pos.X] < field[pos.Y + 1][pos.X])
            {
                field[pos.Y + 1][pos.X] = field[pos.Y][pos.X] + grid[pos.Y + 1][pos.X];
                nextPos.Enqueue((pos.Y + 1, pos.X, field[pos.Y + 1][pos.X]));
            }
            if (pos.X - 1 >= 0 && field[pos.Y][pos.X] + grid[pos.Y][pos.X - 1] < field[pos.Y][pos.X - 1])
            {
                field[pos.Y][pos.X - 1] = field[pos.Y][pos.X] + grid[pos.Y][pos.X - 1];
                nextPos.Enqueue((pos.Y, pos.X - 1, field[pos.Y][pos.X - 1]));
            }
            if (pos.X + 1 < field[0].Length && field[pos.Y][pos.X] + grid[pos.Y][pos.X + 1] < field[pos.Y][pos.X + 1])
            {
                field[pos.Y][pos.X + 1] = field[pos.Y][pos.X] + grid[pos.Y][pos.X + 1];
                nextPos.Enqueue((pos.Y, pos.X + 1, field[pos.Y][pos.X + 1]));
            }
        }

        return field[^1][^1];
    }
}
