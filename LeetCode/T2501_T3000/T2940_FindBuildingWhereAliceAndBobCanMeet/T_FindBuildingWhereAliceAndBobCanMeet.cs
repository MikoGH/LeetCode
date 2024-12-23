namespace LeetCode.T2501_T3000.T2940_FindBuildingWhereAliceAndBobCanMeet;

public class T_FindBuildingWhereAliceAndBobCanMeet
{
    public class BinaryIndexedTree
    {
        private int Size;
        private int[] list;

        public BinaryIndexedTree(int size)
        {
            Size = size;
            list = new int[size + 1];
            Array.Fill(list, int.MaxValue);
        }

        public void Update(int pos, int value)
        {
            while (pos <= Size)
            {
                if (value < list[pos])
                    list[pos] = value;
                pos += pos & -pos;
            }
        }

        public int Get(int pos)
        {
            int min = int.MaxValue;
            while (pos > 0)
            {
                if (list[pos] < min)
                    min = list[pos];
                pos -= pos & -pos;
            }

            return min == int.MaxValue ? -1 : min;
        }
    }

    public int[] LeftmostBuildingQueries(int[] heights, int[][] queries)
    {
        for (int i = 0; i < queries.Length; ++i)
        {
            if (queries[i][0] > queries[i][1])
            {
                (queries[i][0], queries[i][1]) = (queries[i][1], queries[i][0]);
            }
        }

        int[] sortedQueryIndexes = Enumerable.Range(0, queries.Length).ToArray();
        Array.Sort(sortedQueryIndexes, (i, j) => queries[j][1].CompareTo(queries[i][1]));

        int[] sortedHeights = (int[])heights.Clone();
        Array.Sort(sortedHeights);

        int[] result = new int[queries.Length];
        int j = heights.Length - 1;
        var tree = new BinaryIndexedTree(heights.Length);

        foreach (int queryIndex in sortedQueryIndexes)
        {
            int left = queries[queryIndex][0], right = queries[queryIndex][1], pos;
            while (j > right)
            {
                pos = heights.Length - Array.BinarySearch(sortedHeights, heights[j]) + 1;
                tree.Update(pos, j--);
            }

            if (left == right || heights[left] < heights[right])
            {
                result[queryIndex] = right;
                continue;
            }

            pos = heights.Length - Array.BinarySearch(sortedHeights, heights[left]);
            result[queryIndex] = tree.Get(pos);
        }

        return result;
    }


    //var queriesByBuildings = new List<int[]>[heights.Length];
    //for (int i = 0; i < queriesByBuildings.Length; i++)
    //    queriesByBuildings[i] = new List<int[]>();

    //for (int i = 0; i < result.Length; i++)
    //    result[i] = -1;

    //for (int i = 0; i < queries.Length; i++)
    //{
    //    if (queries[i][0] > queries[i][1] && heights[queries[i][0]] > heights[queries[i][1]])
    //    {
    //        result[i] = queries[i][0];
    //        continue;
    //    }

    //    if (queries[i][1] > queries[i][0] && heights[queries[i][1]] > heights[queries[i][0]])
    //    {
    //        result[i] = queries[i][1];
    //        continue;
    //    }

    //    if (queries[i][1] == queries[i][0])
    //    {
    //        result[i] = queries[i][1];
    //        continue;
    //    }

    //    var maxIndex = queries[i][0] > queries[i][1] ? queries[i][0] : queries[i][1];
    //    var maxValue = heights[queries[i][0]] > heights[queries[i][1]] ? heights[queries[i][0]] : heights[queries[i][1]];
    //    queriesByBuildings[maxIndex].Add(new int[] { maxValue, i });
    //}

    //var result = new int[queries.Length];

    //for (int i = 0; i < queries.Length; i++)
    //{
    //    if (queries[i][0] > queries[i][1] && heights[queries[i][0]] > heights[queries[i][1]])
    //    {
    //        result[i] = queries[i][0];
    //    }
    //    else if (queries[i][1] > queries[i][0] && heights[queries[i][1]] > heights[queries[i][0]])
    //    {
    //        result[i] = queries[i][1];
    //    }
    //    else if (queries[i][1] == queries[i][0])
    //    {
    //        result[i] = queries[i][1];
    //    }

    //    var maxIndex = queries[i][0] > queries[i][1] ? queries[i][0] : queries[i][1];
    //    var maxValue = heights[queries[i][0]] > heights[queries[i][1]] ? heights[queries[i][0]] : heights[queries[i][1]];

    //    queries[i] = new int[] { maxIndex, maxValue, i };
    //}

    //Array.Sort(queries, (a, b) =>
    //{
    //    int cmp = b[0].CompareTo(a[0]);
    //    if (cmp == 0)
    //    {
    //        return a[1].CompareTo(b[1]);
    //    }
    //    return cmp;
    //});

    //var stack = new Stack<int[]>();

    //var j = 0;
    //for (int i = heights.Length - 1; i >= 0; i--)
    //{
    //    while (j < queries.Length && queries[j][0] == i)
    //    {
    //        if (result[queries[j][2]] != 0)
    //        {
    //            j++;
    //            continue;
    //        }

    //        while (stack.Count > 0 && stack.Peek()[0] <= queries[j][1])
    //            stack.Pop();

    //        if (stack.Count == 0)
    //        {
    //            result[queries[j++][2]] = -1;
    //            continue;
    //        }

    //        result[queries[j++][2]] = stack.Peek()[1];
    //    }

    //    stack.Push(new int[] { heights[i], i });
    //}

    //return result;

    //    var result = Enumerable.Repeat(-1, queries.Length).ToArray();

    //    var monoStack = new List<int[]>();

    //    var queriesByBuildings = new List<int[]>[heights.Length];
    //    for (int i = 0; i < queriesByBuildings.Length; i++)
    //        queriesByBuildings[i] = new List<int[]>();

    //    for (int i = 0; i < queries.Length; i++)
    //    {
    //        if (queries[i][0] > queries[i][1] && heights[queries[i][0]] > heights[queries[i][1]])
    //        {
    //            result[i] = queries[i][0];
    //            continue;
    //        }

    //        if (queries[i][1] > queries[i][0] && heights[queries[i][1]] > heights[queries[i][0]])
    //        {
    //            result[i] = queries[i][1];
    //            continue;
    //        }

    //        if (queries[i][1] == queries[i][0])
    //        {
    //            result[i] = queries[i][1];
    //            continue;
    //        }

    //        var maxIndex = queries[i][0] > queries[i][1] ? queries[i][0] : queries[i][1];
    //        var maxValue = heights[queries[i][0]] > heights[queries[i][1]] ? heights[queries[i][0]] : heights[queries[i][1]];
    //        queriesByBuildings[maxIndex].Add(new int[] { maxValue, i });
    //    }

    //    for (int i = heights.Length - 1; i >= 0; i--)
    //    {
    //        for (int j = 0; j < queriesByBuildings[i].Count; j++)
    //        {
    //            int pos = BinarySearch(queriesByBuildings[i][j][0], monoStack);
    //            if (pos < monoStack.Count && pos >= 0)
    //            {
    //                result[queriesByBuildings[i][j][1]] = monoStack[pos][1];
    //            }
    //        }

    //        while (monoStack.Count > 0 && monoStack[^1][0] <= heights[i])
    //        {
    //            monoStack.RemoveAt(monoStack.Count - 1);
    //        }

    //        monoStack.Add(new int[] { heights[i], i });
    //    }

    //    return result;
    //}

    //private int BinarySearch(int height, List<int[]> monoStack)
    //{
    //    int l = 0, r = monoStack.Count - 1, s;
    //    while (l <= r)
    //    {
    //        s = (l + r) >> 1;
    //        if (monoStack[s][0] > height)
    //            l = s + 1;
    //        else
    //            r = s - 1;
    //    }
    //    return l - 1;
    //}

    //public int[] LeftmostBuildingQueries(int[] heights, int[][] queries)
    //{
    //    var queriesByBuildings = new List<int[]>[heights.Length];
    //    for (int i = 0; i < queriesByBuildings.Length; i++)
    //        queriesByBuildings[i] = new List<int[]>();

    //    var result = new int[queries.Length];
    //    for (int i = 0; i < result.Length; i++)
    //        result[i] = -1;

    //    for (int i = 0; i < queries.Length; i++)
    //    {
    //        if (queries[i][0] > queries[i][1] && heights[queries[i][0]] > heights[queries[i][1]])
    //        {
    //            result[i] = queries[i][0];
    //            continue;
    //        }

    //        if (queries[i][1] > queries[i][0] && heights[queries[i][1]] > heights[queries[i][0]])
    //        {
    //            result[i] = queries[i][1];
    //            continue;
    //        }

    //        if (queries[i][1] == queries[i][0])
    //        {
    //            result[i] = queries[i][1];
    //            continue;
    //        }

    //        var maxIndex = queries[i][0] > queries[i][1] ? queries[i][0] : queries[i][1];
    //        var maxValue = heights[queries[i][0]] > heights[queries[i][1]] ? heights[queries[i][0]] : heights[queries[i][1]];
    //        queriesByBuildings[maxIndex].Add(new int[] { maxValue, i });
    //    }

    //    var queue = new PriorityQueue<int[], int>(queries.Length);

    //    for (int i = 0; i < heights.Length; i++)
    //    {
    //        while (queue.Count > 0 && queue.Peek()[0] < heights[i])
    //        {
    //            result[queue.Peek()[1]] = i;
    //            queue.Dequeue();
    //        }

    //        for (int j = 0; j < queriesByBuildings[i].Count; j++)
    //        {
    //            queue.Enqueue(queriesByBuildings[i][j], queriesByBuildings[i][j][0]);
    //        }
    //    }

    //    return result;
    //}
}
