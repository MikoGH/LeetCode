namespace LeetCode.T3001_T3500.T3401_T3500.T3483_Unique3DigitEvenNumbers;

public class T_Unique3DigitEvenNumbers
{
    public int TotalNumbers(int[] digits)
    {
        var counts = new int[10];

        for (int i = 0; i < digits.Length; i++)
        {
            counts[digits[i]]++;
        }

        var result = 0;

        for (int i = 1; i < 10; i++)
        {
            if (counts[i] == 0)
                continue;
            counts[i]--;
            for (int j = 0; j < 10; j++)
            {
                if (counts[j] == 0)
                    continue;
                counts[j]--;
                for (int k = 0; k < 10; k += 2)
                {
                    if (counts[k] == 0)
                        continue;
                    result++;
                }
                counts[j]++;
            }
            counts[i]++;
        }

        return result;
    }
}
