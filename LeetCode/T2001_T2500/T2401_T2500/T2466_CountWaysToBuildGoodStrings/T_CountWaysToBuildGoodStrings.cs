namespace LeetCode.T2001_T2500.T2401_T2500.T2466_CountWaysToBuildGoodStrings;

public class T_CountWaysToBuildGoodStrings
{
    const int _mod = (int)1e9 + 7;
    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        var dp = new int[high + 1];
        dp[0] = 1;
        for (int i = 1; i <= high; i++)
        {
            if (i >= zero)
                dp[i] += dp[i - zero];
            if (i >= one)
                dp[i] += dp[i - one];
            dp[i] %= _mod;
        }

        var result = 0;
        for (int i = low; i <= high; i++)
        {
            result += dp[i];
            result %= _mod;
        }

        return result;
    }
}
