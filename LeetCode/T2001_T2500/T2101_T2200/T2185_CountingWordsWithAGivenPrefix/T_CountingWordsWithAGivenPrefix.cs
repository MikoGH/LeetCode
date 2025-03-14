namespace LeetCode.T2001_T2500.T2101_T2200.T2185_CountingWordsWithAGivenPrefix;

public class T_CountingWordsWithAGivenPrefix
{
    public int PrefixCount(string[] words, string pref)
    {
        var result = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith(pref))
                result++;
        }

        return result;
    }
}
