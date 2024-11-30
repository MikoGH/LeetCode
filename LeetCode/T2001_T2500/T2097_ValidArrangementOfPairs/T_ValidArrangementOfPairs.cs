namespace LeetCode.T2001_T2500.T2097_ValidArrangementOfPairs;

public class T_ValidArrangementOfPairs
{
    public int[][] ValidArrangement(int[][] pairs)
    {
        var connections = new Dictionary<int, Stack<int>>();

        var countConnections = new Dictionary<int, int[]>();

        foreach (var pair in pairs)
        {
            countConnections.TryAdd(pair[0], new int[] { 0, 0 });
            countConnections.TryAdd(pair[1], new int[] { 0, 0 });

            connections.TryAdd(pair[0], new Stack<int>());

            countConnections[pair[0]][0]++;
            countConnections[pair[1]][1]++;

            connections[pair[0]].Push(pair[1]);
        }

        var start = connections.Keys.First();
        foreach (var key in countConnections.Keys)
        {
            if (countConnections[key][0] > countConnections[key][1])
                start = key;
        }

        var result = new int[pairs.Length][];
        var i = pairs.Length - 1;
        var stack = new Stack<int>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            var current = stack.Peek();
            if (connections.ContainsKey(current) && connections[current].Count > 0)
            {
                stack.Push(connections[current].Pop());
                continue;
            }
            stack.Pop();
            if (stack.Count > 0)
            {
                result[i--] = new int[] { stack.Peek(), current };
            }
        }

        return result;
    }
}
