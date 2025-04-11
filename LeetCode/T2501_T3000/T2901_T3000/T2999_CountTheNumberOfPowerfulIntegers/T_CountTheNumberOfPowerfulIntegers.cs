namespace LeetCode.T2501_T3000.T2901_T3000.T2999_CountTheNumberOfPowerfulIntegers;

public class T_CountTheNumberOfPowerfulIntegers
{
    public long NumberOfPowerfulInt(long start, long finish, int limit, string s)
    {
        return Calculate(finish.ToString(), s, limit) - Calculate(start.ToString(), s, limit);
    }

    private long Calculate(string x, string s, int limit)
    {
        if (x.Length < s.Length)
            return 0;

        if (x.Length == s.Length)
        {
            if (x.CompareTo(s) >= 0)
                return 1;
            return 0;
        }

        int prefixLength = x.Length - s.Length;
        string xSuffix = x.Substring(prefixLength);
        long count = 0;

        for (int i = 0; i < prefixLength; i++)
        {
            int digit = x[i] - '0';
            if (limit < digit)
            {
                count += (long)Math.Pow(limit + 1, prefixLength - i);
                return count;
            }
            count += (long)digit * (long)Math.Pow(limit + 1, prefixLength - 1 - i);
        }

        if (xSuffix.CompareTo(s) >= 0)
            count++;

        return count;
    }
}
