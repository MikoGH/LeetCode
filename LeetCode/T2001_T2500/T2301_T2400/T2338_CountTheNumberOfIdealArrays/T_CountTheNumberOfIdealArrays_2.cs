namespace LeetCode.T2001_T2500.T2301_T2400.T2338_CountTheNumberOfIdealArrays;

public class T_CountTheNumberOfIdealArrays_2
{
    int mod = (int)1e9 + 7;

    public int IdealArrays(int n, int maxValue)
    {
        var maxP = 15;

        var c = new int[n + maxP, maxP + 1];
        var sieve = new int[n];
        var ps = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            ps[i] = new List<int>();
        }

        for (int i = 2; i < n; i++)
        {
            if (sieve[i] != 0)
                continue;

            for (int j = i; j < n; j += i)
            {
                if (sieve[j] == 0)
                    sieve[j] = i;
            }
        }

        for (var i = 2; i < n; i++)
        {
            int x = i;
            while (x > 1)
            {
                int p = sieve[x];
                int count = 0;
                while (x % p == 0)
                {
                    x /= p;
                    count++;
                }
                ps[i].Add(count);
            }
        }
        c[0, 0] = 1;
        for (int i = 1; i < n + maxP; i++)
        {
            c[i, 0] = 1;
            for (int j = 1; j <= Math.Min(i, maxP); j++)
            {
                c[i, j] = (c[i - 1, j] + c[i - 1, j - 1]) % mod;
            }
        }

        long result = 0;
        for (int x = 1; x <= maxValue; x++)
        {
            long m = 1;
            foreach (var p in ps[x])
            {
                m = (m * c[n + p - 1, p]) % mod;
            }

            result = (result + m) % mod;
        }

        return (int)result;
    }
}
