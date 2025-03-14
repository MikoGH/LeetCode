namespace LeetCode.T1501_T2000.T1901_T2000.T1930_UniqueLength3PalindromicSubsequences;

public class T_UniqueLength3PalindromicSubsequences
{
    public int CountPalindromicSubsequence(string s)
    {
        var firstPos = new int[26];
        var lastPos = new int[26];
        var counts = new int[s.Length + 1][];
        counts[0] = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            if (firstPos[s[i] - 'a'] == 0)
                firstPos[s[i] - 'a'] = i + 1;
            lastPos[s[i] - 'a'] = i + 1;
            counts[i + 1] = (int[])counts[i].Clone();
            counts[i + 1][s[i] - 'a']++;
        }

        var result = 0;

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (lastPos[i] > 0 && counts[lastPos[i] - 1][j] > counts[firstPos[i]][j])
                    result++;
            }
        }

        return result;
    }
}
