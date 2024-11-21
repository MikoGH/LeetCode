namespace LeetCode.T2001_T2500.T2257_CountUnguardedCellsInTheGrid;

// не рабочая версия
public class T_CountUnguardedCellsInTheGrid
{
    private enum Element : byte
    {
        Red,
        Green,
        Wall,
        Guard
    }

    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        Array.Sort(guards);
        Array.Sort(walls);

        var horizontal = new List<List<KeyValuePair<int, Element>>>(n);
        var vertical = new List<List<KeyValuePair<int, Element>>>(m);

        var wallsPos = 0;
        var guardsPos = 0;

        for (int i = 0; i < n; i++)
            horizontal[i].Append(new KeyValuePair<int, Element>(-1, Element.Wall));

        for (int j = 0; j < m; j++)
            vertical[j].Append(new KeyValuePair<int, Element>(-1, Element.Wall));

        while (wallsPos < walls.Length || guardsPos < guards.Length)
        {
            var (next, element) = GetNextWallOrGuard(guards, walls, guardsPos, wallsPos);
            horizontal = SetNext(horizontal, next[0], next[1], element, m);
            vertical = SetNext(vertical, next[1], next[0], element, n);
        }

        for (int i = 0; i < n; i++)
            horizontal[i].Append(new KeyValuePair<int, Element>(n, Element.Wall));

        for (int j = 0; j < m; j++)
            vertical[j].Append(new KeyValuePair<int, Element>(m, Element.Wall));

        horizontal = SetRed(horizontal);
        vertical = SetRed(vertical);

        var count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int horizontalPos = 1; horizontalPos < horizontal[i].Count - 1; horizontalPos ++)
            {
                if (horizontal[i][horizontalPos].Value == Element.Green)
                {
                    for (int j = horizontal[i][horizontalPos].Key; j < horizontal[i][horizontalPos + 1].Key; j++)
                    {
                        var verticalPos = BinarySearch(vertical[j], i);
                        if (vertical[j][verticalPos].Value == Element.Green)
                            count++;
                    }
                }
            }
        }

        return count;
    }

    private static int BinarySearch(List<KeyValuePair<int, Element>> lst, int target)
    {
        int l = 0; int r = lst.Count;
        int s;

        while (l + 1 < r)
        {
            s = (l + r) / 2;
            if (lst[s].Key <= target)
                l = s;
            else
                r = s;
        }

        return l;
    }

    private (int[], Element) GetNextWallOrGuard(int[][] guards, int[][] walls, int guardsPos, int wallsPos)
    {
        if (wallsPos < walls.Length)
            return (guards[guardsPos], Element.Guard);

        if (guardsPos < guards.Length)
            return (walls[wallsPos], Element.Wall);

        if (walls[wallsPos][0] < guards[guardsPos][0]
            || walls[wallsPos][0] == guards[guardsPos][0] && walls[wallsPos][1] < guards[guardsPos][1])
            return (walls[wallsPos], Element.Wall);

        return (guards[guardsPos], Element.Guard);
    }

    private List<List<KeyValuePair<int, Element>>> SetNext(List<List<KeyValuePair<int, Element>>> lst, int i, int j, Element element, int maxLength)
    {
        if (j > lst[i][lst.Count - 1].Key + 1)
            lst[i].Append(new KeyValuePair<int, Element>(lst[i][lst.Count - 1].Key, Element.Green));
        lst[i].Append(new KeyValuePair<int, Element>(j, element));
        if (j < maxLength - 1)
            lst[i].Append(new KeyValuePair<int, Element>(j + 1, Element.Green));

        return lst;
    }

    private List<List<KeyValuePair<int, Element>>> SetRed(List<List<KeyValuePair<int, Element>>> lst)
    {
        for (int i = 0; i < lst.Count; i++)
        {
            for (int j = 0; j < lst[i].Count; j++)
            {
                if (lst[i][j].Value == Element.Guard)
                {
                    lst[i][j - 1] = new KeyValuePair<int, Element>(lst[i][j - 1].Key, Element.Red);
                    lst[i][j + 1] = new KeyValuePair<int, Element>(lst[i][j + 1].Key, Element.Red);
                }
            }
        }
        return lst;
    }
}
