namespace LeetCode.T1001_T1500.T1101_T1200.T1128_NumberOfEquivalentDominoPairs;

public class T_NumberOfEquivalentDominoPairs
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var pairs = new Dictionary<(int, int), int>();

        for (int i = 0; i < dominoes.Length; i++)
        {
            if (dominoes[i][0] > dominoes[i][1])
                (dominoes[i][0], dominoes[i][1]) = (dominoes[i][1], dominoes[i][0]);
            var key = (dominoes[i][0], dominoes[i][1]);
            if (!pairs.ContainsKey(key))
                pairs.Add(key, 1);
            else
                pairs[key]++;
        }

        var result = 0;
        foreach (var value in pairs.Values)
        {
            result += GetSum(value - 1);
        }

        return result;
    }

    private int GetSum(int n)
    {
        if (n % 2 == 0)
            return (n + 1) * (n / 2);
        return (n + 1) * (n / 2) + n / 2 + 1;
    }
}
