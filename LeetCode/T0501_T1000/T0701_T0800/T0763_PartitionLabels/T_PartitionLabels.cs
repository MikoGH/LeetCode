namespace LeetCode.T0501_T1000.T0701_T0800.T0763_PartitionLabels;

public class T_PartitionLabels
{
    public IList<int> PartitionLabels(string s)
    {
        var counts = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'a']++;
        }

        var result = new List<int>() { 0 };
        var visited = new bool[26];
        var distinctLeft = 0;

        for (int i = 0; i < s.Length; i++)
        {
            result[^1]++;
            var smb = s[i] - 'a';
            counts[smb]--;
            if (visited[smb] && counts[smb] == 0)
            {
                visited[smb] = false;
                distinctLeft--;
            }
            else if (!visited[smb] && counts[smb] > 0)
            {
                distinctLeft++;
                visited[smb] = true;
            }

            if (distinctLeft == 0 && i != s.Length - 1)
            {
                result.Add(0);
            }
        }

        return result;
    }
}
