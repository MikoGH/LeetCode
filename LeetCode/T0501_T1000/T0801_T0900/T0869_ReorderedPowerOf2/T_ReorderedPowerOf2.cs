namespace LeetCode.T0501_T1000.T0801_T0900.T0869_ReorderedPowerOf2;

public class T_ReorderedPowerOf2
{
    public bool ReorderedPowerOf2(int n)
    {
        var digitCounts = new int[10];

        while (n > 0)
        {
            digitCounts[n % 10]++;
            n /= 10;
        }

        for (int power = 0; power < 30; power++)
        {
            var powerOf2 = 1 << power;
            var digitCounts2 = new int[10];
            while (powerOf2 > 0)
            {
                digitCounts2[powerOf2 % 10]++;
                powerOf2 /= 10;
            }

            var flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (digitCounts[i] != digitCounts2[i])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                return true;
        }

        return false;
    }
}
