namespace LeetCode.T2501_T3000.T2523_ClosestPrimeNumbersInRange;

public class T_ClosestPrimeNumbersInRange
{
    public int[] ClosestPrimes(int left, int right)
    {
        var notPrimes = new bool[right - left + 1];
        if (left == 1)
            notPrimes[0] = true;

        for (int i = 2; i <= right; i++)
        {
            for (int j = left / i; j < right; j++)
            {
                if (j < 2)
                    continue;
                var index = i * j - left;
                if (index >= notPrimes.Length)
                    break;
                if (index >= 0)
                    notPrimes[index] = true;
            }
        }

        var result = new int[2];
        result[0] = -1;
        result[1] = -1;
        var prev = -1;
        for (int i = 0; i < notPrimes.Length; i++)
        {
            if (notPrimes[i])
                continue;

            var number = i + left;

            if ((result[1] - result[0] > number - prev || result[0] == -1) && prev != -1)
            {
                result[0] = prev;
                result[1] = number;
            }

            prev = number;
        }

        return result;
    }
}
