namespace LeetCode.T3001_T3500.T3301_T3400.T3333_FindTheOriginalTypedStringII;

public class T_FindTheOriginalTypedStringII
{
    int MOD = (int)1e9 + 7;

    public int PossibleStringCount(string word, int k)
    {
        var groups = new List<int>();

        groups.Add(1);

        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
                groups[^1]++;
            else
                groups.Add(1);
        }

        long total = 1;
        foreach (var value in groups)
            total = (total * value) % MOD;

        if (k <= groups.Count)
            return (int)total;

        var dp = new int[k];
        dp[0] = 1;

        foreach (var value in groups)
        {
            var new_dp = new int[k];
            long sum = 0;
            for (int i = 0; i < k; i++)
            {
                if (i > 0)
                    sum = (sum + dp[i - 1]) % MOD;
                if (i > value)
                    sum = (sum - dp[i - value - 1] + MOD) % MOD;
                new_dp[i] = (int)sum;
            }
            dp = new_dp;
        }

        long lessK = 0;
        foreach (var value in dp)
            lessK = (lessK + value) % MOD;

        return (int)((total - lessK + MOD) % MOD);
    }
}
