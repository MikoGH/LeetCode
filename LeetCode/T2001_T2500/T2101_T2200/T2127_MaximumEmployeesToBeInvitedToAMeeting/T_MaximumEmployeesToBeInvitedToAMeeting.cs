namespace LeetCode.T2001_T2500.T2101_T2200.T2127_MaximumEmployeesToBeInvitedToAMeeting;

public class T_MaximumEmployeesToBeInvitedToAMeeting
{
    public int _maxCycleLength = 0;
    public int _totalPairsLength = 0;

    public int MaximumInvitations(int[] favorite)
    {
        var currentLengths = new int[favorite.Length];
        var lastNodes = new int[favorite.Length];
        var visited = new bool[favorite.Length];
        var lastNodesDct = new Dictionary<int, int>();
        var lengthToLast = new int[favorite.Length];

        for (int i = 0; i < favorite.Length; i++)
        {
            lastNodes[i] = -1;
            if (i == favorite[favorite[i]])
            {
                lastNodesDct.Add(i, 1);
                _totalPairsLength++;
            }
        }

        for (int i = 0; i < favorite.Length; i++)
        {
            Dfs(favorite, currentLengths, lastNodes, visited, lastNodesDct, lengthToLast, 1, i, i);
        }

        return Math.Max(_totalPairsLength, _maxCycleLength);
    }

    public (int, int) Dfs(int[] favorite, int[] currentLengths, int[] lastNodes, bool[] visited, Dictionary<int, int> lastNodesDct, int[] lengthToLast, int currentLength, int currentNode, int startNode)
    {
        if (lastNodesDct.ContainsKey(currentNode))
        {
            var pairsLength = currentLength;
            if (pairsLength > lastNodesDct[currentNode])
            {
                _totalPairsLength += pairsLength - lastNodesDct[currentNode];
                lastNodesDct[currentNode] = pairsLength;
            }
            return (1, currentNode);
        }

        if (currentLengths[currentNode] > 0)
        {
            var cycleLength = currentLength - currentLengths[currentNode];
            if (cycleLength > _maxCycleLength)
                _maxCycleLength = cycleLength;
            return (-1, -1);
        }

        if (visited[currentNode])
        {
            var currentLastNode = lastNodes[currentNode];
            if (currentLastNode != -1)
            {
                var pairsLength = currentLength + lengthToLast[currentNode] - 1;
                if (pairsLength > lastNodesDct[currentLastNode])
                {
                    _totalPairsLength += pairsLength - lastNodesDct[currentLastNode];
                    lastNodesDct[currentLastNode] = pairsLength;
                }
                return (lengthToLast[currentNode], currentLastNode);
            }
            return (-1, -1);
        }

        visited[currentNode] = true;
        currentLengths[currentNode] = currentLength;
        (int length, int lastNode) = Dfs(favorite, currentLengths, lastNodes, visited, lastNodesDct, lengthToLast, currentLength + 1, favorite[currentNode], startNode);
        currentLengths[currentNode] = 0;
        length++;

        if (lastNode != -1)
        {
            lastNodes[currentNode] = lastNode;
            lengthToLast[currentNode] = length;
            return (length, lastNode);
        }

        return (-1, -1);
    }
}
