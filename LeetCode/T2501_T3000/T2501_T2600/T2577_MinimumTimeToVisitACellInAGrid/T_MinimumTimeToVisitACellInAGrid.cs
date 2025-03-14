namespace LeetCode.T2501_T3000.T2501_T2600.T2577_MinimumTimeToVisitACellInAGrid;

public class T_MinimumTimeToVisitACellInAGrid
{
    PriorityQueue<(int Y, int X, int Distance), int> _nextPos = new PriorityQueue<(int Y, int X, int Distance), int>();
    int[][] _field;
    int[][] _grid;

    public int MinimumTime(int[][] grid)
    {
        _grid = grid;
        _field = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            _field[i] = Enumerable.Repeat(int.MaxValue, grid[i].Length).ToArray();
        }

        if (_grid[1][0] > 1 && _grid[0][1] > 1)
            return -1;

        _field[0][0] = 0;
        _nextPos.Enqueue((0, 0, 0), 0);

        while (_nextPos.Count > 0)
        {
            var pos = _nextPos.Peek();
            _nextPos.Dequeue();

            if (pos.Distance > _field[pos.Y][pos.X])
                continue;

            _nextPos = AddNextPos(pos.Y, pos.X, pos.Distance, pos.Y - 1, pos.X);
            _nextPos = AddNextPos(pos.Y, pos.X, pos.Distance, pos.Y + 1, pos.X);
            _nextPos = AddNextPos(pos.Y, pos.X, pos.Distance, pos.Y, pos.X - 1);
            _nextPos = AddNextPos(pos.Y, pos.X, pos.Distance, pos.Y, pos.X + 1);
        }

        return _field[^1][^1];
    }

    private PriorityQueue<(int Y, int X, int Distance), int> AddNextPos(int y, int x, int distance, int nextY, int nextX)
    {
        if (nextY >= 0 && nextX >= 0 && nextY < _field.Length && nextX < _field[0].Length)
        {
            var difference = _grid[nextY][nextX] - _field[y][x];
            var added = 1;
            if (difference > 0)
                added = difference % 2 == 0 ? difference + 1 : difference;
            if (_field[y][x] + added < _field[nextY][nextX])
            {
                _field[nextY][nextX] = _field[y][x] + added;
                _nextPos.Enqueue((nextY, nextX, _field[nextY][nextX]), _field[nextY][nextX]);
            }
        }

        return _nextPos;
    }
}
