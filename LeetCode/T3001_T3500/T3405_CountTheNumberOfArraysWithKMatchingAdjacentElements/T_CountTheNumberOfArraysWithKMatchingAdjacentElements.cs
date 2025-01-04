namespace LeetCode.T3001_T3500.T3405_CountTheNumberOfArraysWithKMatchingAdjacentElements;

public class T_CountTheNumberOfArraysWithKMatchingAdjacentElements
{
    const int _mod = 1_000_000_007;

    public long Pow(long num, int pow)
    {
        long result = 1;

        while (pow > 0)
        {
            if (pow % 2 == 1)
                result = (result * num) % _mod;
            num = (num * num) % _mod;
            pow >>= 1;
        }

        return result;
    }

    public int CountGoodArrays(int n, int m, int k)
    {
        long f1 = 1, f2 = 1;
        for (int i = k + 1; i < n; i++)
        {
            f1 = (f1 * i) % _mod;
        }
        for (int i = 2; i < n - k; i++)
        {
            f2 = (f2 * i) % _mod;
        }

        long result = (f1 * Pow(f2, _mod - 2)) % _mod;
        result = (result * m) % _mod;
        result = (result * Pow(m - 1, n - k - 1)) % _mod;

        return (int)result;
    }
}
