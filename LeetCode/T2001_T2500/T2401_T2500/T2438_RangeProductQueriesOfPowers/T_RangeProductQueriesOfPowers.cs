namespace LeetCode.T2001_T2500.T2401_T2500.T2438_RangeProductQueriesOfPowers;

public class T_RangeProductQueriesOfPowers
{
    private const long Mod = (int)1e9 + 7;

    public int[] ProductQueries(int n, int[][] queries)
    {
        var powers = new List<long>((int)Math.Ceiling(Math.Log2(n)));

        var power = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
                powers.Add(1 << power);

            power++;
            n >>= 1;
        }

        var result = new int[queries.Length];

        var resultIndex = 0;
        foreach (var query in queries)
        {
            result[resultIndex] = 1;
            for (int i = query[0]; i <= query[1]; i++)
            {
                result[resultIndex] = (int)(((long)result[resultIndex] * powers[i]) % Mod);
            }
            resultIndex++;
        }

        return result;
    }
}
