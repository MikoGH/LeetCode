namespace LeetCode.T2501_T3000.T2701_T2800.T2787_WaysToExpressAnIntegerAsSumOfPowers;

public class T_WaysToExpressAnIntegerAsSumOfPowers
{
    private const int Mod = (int)1e9 + 7;

    public int NumberOfWays(int n, int x)
    {
        var dp = new long[n + 1, n + 1];
        dp[0, 0] = 1;
        for (int i = 1; i <= n; i++)
        {
            var pow = (long)Math.Pow(i, x);
            for (int j = 0; j <= n; j++)
            {
                if (j >= pow)
                    dp[i, j] = (dp[i - 1, j] + dp[i - 1, j - pow]) % Mod;
                else
                    dp[i, j] = dp[i - 1, j];
            }
        }

        return (int)dp[n, n];
    }
}
