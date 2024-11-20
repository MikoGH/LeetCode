namespace LeetCode.T0001_T0500.T0044_WildcardMatching;

public class T_WildcardMatching_3
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p) && !string.IsNullOrEmpty(s))
            return false;

        var dp = new bool[p.Length + 1];

        dp[0] = true;
        for (int j = 1; j <= p.Length; j++)
        {
            if (p[j - 1] == '*')
                dp[j] = dp[j - 1];
        }

        bool prev;
        for (int i = 1; i <= s.Length; i++)
        {
            prev = i == 1 ? true : false;
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == s[i - 1] || p[j - 1] == '?')
                {
                    (prev, dp[j]) = (dp[j], prev);
                    continue;
                }

                prev = dp[j];

                if (p[j - 1] == '*')
                {
                    dp[j] = dp[j] || dp[j - 1];
                    continue;
                }

                dp[j] = false;
            }

            Console.Write($"{(prev ? 1 : 0)} ");
            for (int j = 1; j <= p.Length; j++)
                Console.Write($"{(dp[j] ? 1 : 0)} ");
            Console.WriteLine();
        }

        return dp[p.Length];
    }
}
