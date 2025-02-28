namespace LeetCode.T1001_T1500.T1092_ShortestCommonSupersequence;

public class T_ShortestCommonSupersequence_2
{
    public string ShortestCommonSupersequence(string str1, string str2)
    {
        int i, j;
        var dp = new int[str2.Length + 1][];

        for (i = 0; i < str2.Length + 1; i++)
            dp[i] = new int[str1.Length + 1];

        for (i = 1; i < str2.Length + 1; i++)
        {
            for (j = 1; j < str1.Length + 1; j++)
            {
                if (str2[i - 1] == str1[j - 1])
                {
                    dp[i][j] = Math.Max(dp[i][j - 1], dp[i - 1][j - 1] + 1);
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i][j - 1], dp[i - 1][j]);
                }
            }
        }

        var result = new char[str1.Length + str2.Length - dp[^1][^1]];
        var pos = result.Length - 1;

        i = str2.Length;
        j = str1.Length;
        while (i > 0 || j > 0)
        {
            if (j > 0 && dp[i][j] == dp[i][j - 1])
            {
                result[pos--] = str1[j - 1];
                j--;
                continue;
            }

            result[pos--] = str2[i - 1];
            if (j > 0 && dp[i - 1][j] == dp[i - 1][j - 1])
                j--;
            i--;
        }

        return new string(result);
    }
}
