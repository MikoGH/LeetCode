namespace LeetCode.T3001_T3500.T3001_T3100.T3042_CountPrefixAndSuffixPairsI;

public class T_CountPrefixAndSuffixPairsI
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        var count = 0;

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (IsPrefixAndSuffix(words[i], words[j]))
                    count++;
            }
        }

        return count;
    }

    private bool IsPrefixAndSuffix(string str1, string str2)
    {
        if (str2.Length < str1.Length)
            return false;

        var postfixStart = str2.Length - str1.Length;

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i] || str1[i] != str2[postfixStart + i])
                return false;
        }

        return true;
    }
}
