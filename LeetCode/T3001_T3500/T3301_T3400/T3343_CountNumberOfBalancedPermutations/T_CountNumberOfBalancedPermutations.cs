namespace LeetCode.T3001_T3500.T3301_T3400.T3343_CountNumberOfBalancedPermutations;

public class T_CountNumberOfBalancedPermutations
{
    long _result = 0;
    int _halfSum = 0;
    int _halfLen = 0;
    int _mod = (int)1e9 + 7;

    public int CountBalancedPermutations(string num)
    {
        var counts = new int[10];
        var totalSum = 0;

        foreach (var smb in num)
        {
            var number = smb - '0';
            counts[number]++;
            totalSum += number;
        }

        if (totalSum % 2 == 1)
            return 0;

        _halfSum = totalSum / 2;
        _halfLen = (num.Length + 1) / 2;

        var combinations = new long[_halfLen + 1][];
        for (int i = 0; i <= _halfLen; i++)
            combinations[i] = new long[_halfLen + 1];

        for (int i = 0; i <= _halfLen; i++)
        {
            combinations[i][i] = 1;
            combinations[i][0] = 1;
            for (int j = 1; j < i; j++)
                combinations[i][j] = (combinations[i - 1][j] + combinations[i - 1][j - 1]) % _mod;
        }

        var prefSum = new int[11];
        for (int i = 9; i >= 0; i--)
            prefSum[i] = prefSum[i + 1] + counts[i];

        var memo = new long[10][][];
        for (int i = 0; i < 10; i++)
        {
            memo[i] = new long[_halfSum + 1][];
            for (int j = 0; j < _halfSum + 1; j++)
            {
                memo[i][j] = new long[_halfLen + 1];
                Array.Fill(memo[i][j], -1);
            }
        }

        return (int)Dfs(combinations, prefSum, memo, counts, 0, 0, _halfLen);
    }

    private long Dfs(long[][] combinations, int[] prefSum, long[][][] memo, int[] counts, int pos, int current, int oddCount)
    {
        if (oddCount < 0 || prefSum[pos] < oddCount || current > _halfSum)
            return 0;

        if (pos > 9)
            return current == _halfSum && oddCount == 0 ? 1 : 0;

        if (memo[pos][current][oddCount] != -1)
            return memo[pos][current][oddCount];

        int evenCount = prefSum[pos] - oddCount;
        long result = 0;
        for (int i = Math.Max(0, counts[pos] - evenCount); i <= Math.Min(counts[pos], oddCount); i++)
        {
            long ways = (combinations[oddCount][i] * combinations[evenCount][counts[pos] - i]) % _mod;
            result = (result + ((ways * Dfs(combinations, prefSum, memo, counts, pos + 1, current + i * pos, oddCount - i)) % _mod)) % _mod;
        }
        memo[pos][current][oddCount] = result;
        return result;
    }

    //private void Backtracking(int[] counts, int number, int sum, int len)
    //{
    //    if (len == _halfLen)
    //    {
    //        //_result = (_result + ) % _mod;
    //        return;
    //    }

    //    for (int i = 0; i < counts[number]; i++)
    //    {
    //        Backtracking()
    //    }
    //}
}
