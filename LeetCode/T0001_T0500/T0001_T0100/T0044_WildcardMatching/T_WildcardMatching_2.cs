namespace LeetCode.T0001_T0500.T0001_T0100.T0044_WildcardMatching;

public class T_WildcardMatching_2
{
    public bool IsMatch(string s, string p)
    {
        var dp = new bool[p.Length + 1];
        var dp2 = new bool[p.Length + 1];

        dp[0] = true;
        for (int j = 1; j <= p.Length; j++)
        {
            if (p[j - 1] == '*')
                dp[j] = dp[j - 1];
        }

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == s[i - 1] || p[j - 1] == '?')
                {
                    dp2[j] = dp[j - 1];
                    continue;
                }

                if (p[j - 1] == '*')
                {
                    dp2[j] = dp[j] || dp2[j - 1];
                    continue;
                }

                dp2[j] = false;
            }
            dp = dp2;
            dp2 = new bool[p.Length + 1];
        }

        return dp[p.Length];
    }
}
