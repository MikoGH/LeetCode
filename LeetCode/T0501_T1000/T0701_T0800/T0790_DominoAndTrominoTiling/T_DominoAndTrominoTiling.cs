namespace LeetCode.T0501_T1000.T0701_T0800.T0790_DominoAndTrominoTiling;

public class T_DominoAndTrominoTiling
{
    public int NumTilings(int n)
    {
        if (n < 3)
            return n;

        var mod = (int)1e9 + 7;

        var dp = new long[n + 1];
        var sums = new long[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;
        sums[0] = dp[0] * 2;
        sums[1] = sums[0] + dp[1] * 2;
        sums[2] = sums[1] + dp[2] * 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = (dp[i - 1] + dp[i - 2] + sums[i - 3]) % mod;
            sums[i] = (sums[i - 1] + dp[i] * 2) % mod;
        }

        return (int)dp[n];
    }
}
