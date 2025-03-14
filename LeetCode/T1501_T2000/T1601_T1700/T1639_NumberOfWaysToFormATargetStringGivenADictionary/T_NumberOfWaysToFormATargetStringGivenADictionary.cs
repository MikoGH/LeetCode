namespace LeetCode.T1501_T2000.T1601_T1700.T1639_NumberOfWaysToFormATargetStringGivenADictionary;

public class T_NumberOfWaysToFormATargetStringGivenADictionary
{
    public int NumWays(string[] words, string target)
    {
        const int mod = (int)(1e9 + 7);

        var charFrequencyByIndex = new int[words[0].Length][];
        for (int i = 0; i < charFrequencyByIndex.Length; i++)
        {
            charFrequencyByIndex[i] = new int[26];
            for (int j = 0; j < words.Length; j++)
            {
                charFrequencyByIndex[i][words[j][i] - 'a']++;
            }
        }

        var dp = new long[target.Length + 1];
        dp[0] = 1;
        long prev;
        for (int i = 0; i < words[0].Length; i++)
        {
            prev = 1;
            for (int j = 1; j < dp.Length; j++)
            {
                var tmp = dp[j];
                dp[j] = (dp[j] + charFrequencyByIndex[i][target[j - 1] - 'a'] * prev) % mod;
                prev = tmp;
            }
        }

        return (int)dp[^1];
    }
}
