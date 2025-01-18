namespace LeetCode.T1001_T1500.T1368_MinimumCostToMakeAtLeastOneValidPathInAGrid;

public class T_MinimumCostToMakeAtLeastOneValidPathInAGrid
{
    public int MinCost(int[][] grid)
    {
        var costs = new int[grid.Length][];

        for (int i = 0; i < grid.Length; i++)
        {
            costs[i] = new int[grid[i].Length];
            for (int j = 0; j < grid[i].Length; j++)
            {
                costs[i][j] = int.MaxValue;
            }
        }

        var queue = new PriorityQueue<(int Y, int X, int Cost), int>();
        (int Y, int X, int Cost) point = (0, 0, 0);
        queue.Enqueue(point, point.Cost);
        costs[0][0] = point.Cost;

        while (queue.Count > 0)
        {
            point = queue.Dequeue();
            if (point.Cost > costs[point.Y][point.X])
                continue;

            if (point.Y == grid.Length - 1 && point.X == grid[0].Length - 1)
                break;

            if (point.Y - 1 >= 0)
            {
                var cost = point.Cost;
                if (grid[point.Y][point.X] != 4)
                    cost++;
                if (costs[point.Y - 1][point.X] > cost)
                {
                    costs[point.Y - 1][point.X] = cost;
                    queue.Enqueue((point.Y - 1, point.X, cost), cost);
                }
            }
            if (point.Y + 1 < grid.Length)
            {
                var cost = point.Cost;
                if (grid[point.Y][point.X] != 3)
                    cost++;
                if (costs[point.Y + 1][point.X] > cost)
                {
                    costs[point.Y + 1][point.X] = cost;
                    queue.Enqueue((point.Y + 1, point.X, cost), cost);
                }
            }
            if (point.X - 1 >= 0)
            {
                var cost = point.Cost;
                if (grid[point.Y][point.X] != 2)
                    cost++;
                if (costs[point.Y][point.X - 1] > cost)
                {
                    costs[point.Y][point.X - 1] = cost;
                    queue.Enqueue((point.Y, point.X - 1, cost), cost);
                }
            }
            if (point.X + 1 < grid[0].Length)
            {
                var cost = point.Cost;
                if (grid[point.Y][point.X] != 1)
                    cost++;
                if (costs[point.Y][point.X + 1] > cost)
                {
                    costs[point.Y][point.X + 1] = cost;
                    queue.Enqueue((point.Y, point.X + 1, cost), cost);
                }
            }
        }

        return point.Cost;
    }
}
