namespace LeetCode.T0501_T1000.T0801_T0900.T0827_MakingALargeIsland;

public class T_MakingALargeIsland
{
    public int LargestIsland(int[][] grid)
    {
        var groupByNode = new Dictionary<(int Y, int X), int>(grid.Length * grid[0].Length);
        var sizeByGroup = new Dictionary<int, int>();
        var visited = new bool[grid.Length][];
        for (var i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }

        var queue = new Queue<(int Y, int X)>();
        var groupNum = 0;
        var maxSum = 1;
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (visited[i][j] || grid[i][j] == 0)
                    continue;

                groupNum++;
                sizeByGroup.Add(groupNum, 0);
                queue.Enqueue((i, j));
                visited[i][j] = true;
                while (queue.Count > 0)
                {
                    var position = queue.Dequeue();
                    groupByNode.Add(position, groupNum);
                    sizeByGroup[groupNum]++;

                    if (position.Y - 1 >= 0 && grid[position.Y - 1][position.X] == 1 && !visited[position.Y - 1][position.X])
                    {
                        queue.Enqueue((position.Y - 1, position.X));
                        visited[position.Y - 1][position.X] = true;
                    }
                    if (position.Y + 1 < grid.Length && grid[position.Y + 1][position.X] == 1 && !visited[position.Y + 1][position.X])
                    {
                        queue.Enqueue((position.Y + 1, position.X));
                        visited[position.Y + 1][position.X] = true;
                    }
                    if (position.X - 1 >= 0 && grid[position.Y][position.X - 1] == 1 && !visited[position.Y][position.X - 1])
                    {
                        queue.Enqueue((position.Y, position.X - 1));
                        visited[position.Y][position.X - 1] = true;
                    }
                    if (position.X + 1 < grid[0].Length && grid[position.Y][position.X + 1] == 1 && !visited[position.Y][position.X + 1])
                    {
                        queue.Enqueue((position.Y, position.X + 1));
                        visited[position.Y][position.X + 1] = true;
                    }
                }
                if (sizeByGroup[groupNum] > maxSum)
                    maxSum = sizeByGroup[groupNum];
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    var adjacentGroups = new List<int>();
                    if (i - 1 >= 0 && grid[i - 1][j] == 1 && !adjacentGroups.Contains(groupByNode[(i - 1, j)]))
                    {
                        adjacentGroups.Add(groupByNode[(i - 1, j)]);
                    }
                    if (i + 1 < grid.Length && grid[i + 1][j] == 1 && !adjacentGroups.Contains(groupByNode[(i + 1, j)]))
                    {
                        adjacentGroups.Add(groupByNode[(i + 1, j)]);
                    }
                    if (j - 1 >= 0 && grid[i][j - 1] == 1 && !adjacentGroups.Contains(groupByNode[(i, j - 1)]))
                    {
                        adjacentGroups.Add(groupByNode[(i, j - 1)]);
                    }
                    if (j + 1 < grid[0].Length && grid[i][j + 1] == 1 && !adjacentGroups.Contains(groupByNode[(i, j + 1)]))
                    {
                        adjacentGroups.Add(groupByNode[(i, j + 1)]);
                    }

                    var sum = 1;
                    for (int k = 0; k < adjacentGroups.Count; k++)
                    {
                        sum += sizeByGroup[adjacentGroups[k]];
                    }
                    if (sum > maxSum)
                        maxSum = sum;
                }
            }
        }

        return maxSum;
    }
}
