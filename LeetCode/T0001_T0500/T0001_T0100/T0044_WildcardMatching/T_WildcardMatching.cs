namespace LeetCode.T0001_T0500.T0001_T0100.T0044_WildcardMatching;

public class T_WildcardMatching
{
    public bool IsMatch(string s, string p)
    {
        var dp = new bool[s.Length + 1, p.Length + 1];

        dp[0, 0] = true;
        for (int j = 1; j <= p.Length; j++)
        {
            if (p[j - 1] == '*')
                dp[0, j] = dp[0, j - 1];
        }

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == s[i - 1] || p[j - 1] == '?')
                {
                    dp[i, j] = dp[i - 1, j - 1];
                    continue;
                }

                if (p[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 1] || dp[i - 1, j];
                    continue;
                }

                dp[i, j] = false;
            }
        }

        for (int i = 0; i <= s.Length; i++)
        {
            for (int j = 0; j <= p.Length; j++)
                Console.Write($"{(dp[i, j] ? 1 : 0)} ");
            Console.WriteLine();
        }

        return dp[s.Length, p.Length];
    }
}
