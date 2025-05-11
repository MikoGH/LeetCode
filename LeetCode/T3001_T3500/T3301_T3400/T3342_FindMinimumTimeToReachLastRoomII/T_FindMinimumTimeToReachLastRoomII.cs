namespace LeetCode.T3001_T3500.T3301_T3400.T3342_FindMinimumTimeToReachLastRoomII;

public class T_FindMinimumTimeToReachLastRoomII
{
    public int MinTimeToReach(int[][] moveTime)
    {
        var visited = new bool[moveTime.Length][];
        for (int i = 0; i < moveTime.Length; i++)
            visited[i] = new bool[moveTime[i].Length];
        moveTime[0][0] = 0;

        var queue = new PriorityQueue<(int X, int Y, int Add), int>();
        queue.Enqueue((0, 0, 1), 0);
        visited[0][0] = true;

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            var nextAdd = cell.Add == 1 ? 2 : 1;

            var nextCells = new (int X, int Y, int Add)[4]
            {
                (cell.X, cell.Y - 1, nextAdd),
                (cell.X - 1, cell.Y, nextAdd),
                (cell.X + 1, cell.Y, nextAdd),
                (cell.X, cell.Y + 1, nextAdd)
            };

            foreach (var nextCell in nextCells)
            {
                if (!IsInsideBounds(nextCell.X, nextCell.Y, moveTime[0].Length, moveTime.Length) || visited[nextCell.Y][nextCell.X])
                    continue;

                var minTime = Math.Max(moveTime[nextCell.Y][nextCell.X] + cell.Add, moveTime[cell.Y][cell.X] + cell.Add);

                queue.Enqueue((nextCell.X, nextCell.Y, nextAdd), minTime);
                moveTime[nextCell.Y][nextCell.X] = minTime;
                visited[nextCell.Y][nextCell.X] = true;
            }
        }

        return moveTime[^1][^1];
    }

    private bool IsInsideBounds(int x, int y, int width, int height)
    {
        return x >= 0 && y >= 0 && x < width && y < height;
    }
}
