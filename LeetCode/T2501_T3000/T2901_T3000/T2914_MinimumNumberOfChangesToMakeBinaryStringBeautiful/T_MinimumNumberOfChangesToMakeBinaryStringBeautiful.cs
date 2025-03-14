namespace LeetCode.T2501_T3000.T2901_T3000.T2914_MinimumNumberOfChangesToMakeBinaryStringBeautiful;

public class T_MinimumNumberOfChangesToMakeBinaryStringBeautiful
{
    public int MinChanges(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i += 2)
        {
            if (s[i + 1] != s[i])
                count++;
        }

        return count;
    }
}
