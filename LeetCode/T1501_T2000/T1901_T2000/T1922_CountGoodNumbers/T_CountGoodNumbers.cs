namespace LeetCode.T1501_T2000.T1901_T2000.T1922_CountGoodNumbers;

public class T_CountGoodNumbers
{
    const int Mod = (int)1e9 + 7;

    public int CountGoodNumbers(long n)
    {
        long evenPow = (n + 1) >> 1;
        long oddPow = n >> 1;

        long evenCount = 5;
        long oddCount = 4;

        long evenResult = Pow(evenCount, evenPow);
        long oddResult = Pow(oddCount, oddPow);

        return (int)((evenResult * oddResult) % Mod);
    }

    private long Pow(long count, long pow)
    {
        long result = 1;

        while (pow > 0)
        {
            if (pow % 2 == 1)
                result = (result * count) % Mod;
            count = (count * count) % Mod;
            pow >>= 1;
        }

        return result;
    }
}
