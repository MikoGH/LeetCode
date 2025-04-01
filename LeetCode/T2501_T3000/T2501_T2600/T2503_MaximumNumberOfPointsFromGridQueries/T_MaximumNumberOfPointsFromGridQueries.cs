namespace LeetCode.T2501_T3000.T2501_T2600.T2503_MaximumNumberOfPointsFromGridQueries;

public class T_MaximumNumberOfPointsFromGridQueries
{
    public int[] MaxPoints(int[][] grid, int[] queries)
    {
        var max = 0;
        var visited = new bool[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[0].Length];
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] > max)
                    max = grid[i][j];
        }
        max = Math.Max(max, queries.Max());

        var nums = new int[max + 1];

        var count = 0;
        var num = 0;

        var queue = new PriorityQueue<(int X, int Y), int>();
        queue.Enqueue((0, 0), grid[0][0]);
        visited[0][0] = true;

        var d = new int[] { -1, 0, 1, 0, -1 };

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();

            while (num <= grid[cell.Y][cell.X])
            {
                nums[num++] = count;
            }

            count++;

            for (int i = 0; i < 4; i++)
            {
                var x = cell.X + d[i];
                var y = cell.Y + d[i + 1];
                if (x < 0 || y < 0 || x >= grid[0].Length || y >= grid.Length)
                    continue;
                if (visited[y][x])
                    continue;

                queue.Enqueue((x, y), grid[y][x]);
                visited[y][x] = true;
            }
        }

        while (num < nums.Length)
        {
            nums[num++] = count;
        }

        var result = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = nums[queries[i]];
        }

        return result;
    }
}
