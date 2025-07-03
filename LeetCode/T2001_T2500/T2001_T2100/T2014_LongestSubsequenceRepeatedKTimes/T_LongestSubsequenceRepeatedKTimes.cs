namespace LeetCode.T2001_T2500.T2001_T2100.T2014_LongestSubsequenceRepeatedKTimes;

public class T_LongestSubsequenceRepeatedKTimes
{
    public string LongestSubsequenceRepeatedK(string s, int k)
    {
        int[] counts = new int[26];
        foreach (char ch in s)
        {
            counts[ch - 'a']++;
        }

        var smbs = new List<char>();
        for (int i = 25; i >= 0; i--)
        {
            if (counts[i] >= k)
                smbs.Add((char)('a' + i));
        }

        var queue = new Queue<string>();
        foreach (var smb in smbs)
            queue.Enqueue(smb.ToString());

        string result = "";
        while (queue.Count > 0)
        {
            string curr = queue.Dequeue();
            if (curr.Length > result.Length)
            {
                result = curr;
            }

            foreach (var smb in smbs)
            {
                string next = curr + smb;
                if (Check(s, next, k))
                {
                    queue.Enqueue(next);
                }
            }
        }

        return result;
    }

    private bool Check(string s, string t, int k)
    {
        int pos = 0;
        int count = 0;
        foreach (var smb in s)
        {
            if (smb != t[pos])
                continue;
            pos++;
            if (pos != t.Length)
                continue;
            pos = 0;
            count++;
            if (count == k)
                return true;
        }

        return false;
    }
}
