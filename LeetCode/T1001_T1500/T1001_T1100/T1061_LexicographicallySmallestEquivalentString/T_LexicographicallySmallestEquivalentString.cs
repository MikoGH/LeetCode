using System.Threading.Tasks.Dataflow;

namespace LeetCode.T1001_T1500.T1001_T1100.T1061_LexicographicallySmallestEquivalentString;

public class T_LexicographicallySmallestEquivalentString
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var connections = new List<int>[26];
        for (int i = 0; i < 26; i++)
            connections[i] = new List<int>();

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == s2[i])
                continue;

            connections[s1[i] - 'a'].Add(s2[i] - 'a');
            connections[s2[i] - 'a'].Add(s1[i] - 'a');
        }

        var visited = new bool[26];
        var minByGroup = new List<int>();
        var groups = new int[26];
        for (int i = 0; i < 26; i++)
        {
            if (visited[i])
                continue;
            minByGroup.Add(i);
            Dfs(visited, connections, minByGroup, groups, i);
        }

        var result = new char[baseStr.Length];
        for (int i = 0; i < baseStr.Length; i++)
        {
            result[i] = (char)(minByGroup[groups[baseStr[i] - 'a']] + 'a');
        }

        return new string(result);
    }

    private void Dfs(bool[] visited, List<int>[] connections, List<int> minByGroup, int[] groups, int index)
    {
        visited[index] = true;
        groups[index] = minByGroup.Count - 1;
        if (index < minByGroup[^1])
            minByGroup[^1] = index;

        foreach(var connection in connections[index])
        {
            if (visited[connection])
                continue;
            Dfs(visited, connections, minByGroup, groups, connection);
        }
    }
}
