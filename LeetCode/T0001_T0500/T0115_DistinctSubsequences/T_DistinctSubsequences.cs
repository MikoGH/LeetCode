namespace LeetCode.T0001_T0500.T0115_DistinctSubsequences;

public class T_DistinctSubsequences
{
    public int NumDistinct(string s, string t)
    {
        var dp = new int[t.Length];
        var prev = 0;

        for (int i = 0; i < s.Length; i++)
        {
            prev = 1;
            for (int j = 0; j < t.Length; j++)
            {
                if (s[i] != t[j])
                {
                    prev = dp[j];
                    continue;
                }

                var sum = prev + dp[j];
                prev = dp[j];
                dp[j] = sum;
            }
        }

        return dp[^1];
    }
}
