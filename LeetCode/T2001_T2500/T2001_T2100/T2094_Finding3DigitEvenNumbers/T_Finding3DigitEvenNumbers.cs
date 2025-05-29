namespace LeetCode.T2001_T2500.T2001_T2100.T2094_Finding3DigitEvenNumbers;

public class T_Finding3DigitEvenNumbers
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var counts = new int[10];
        foreach (var digit in digits)
        {
            counts[digit]++;
        }

        var result = new List<int>();

        for (int first = 1; first < 10; first++)
        {
            if (counts[first] == 0)
                continue;
            counts[first]--;
            for (int second = 0; second < 10; second++)
            {
                if (counts[second] == 0)
                    continue;
                counts[second]--;
                for (int third = 0; third < 10; third+=2)
                {
                    if (counts[third] == 0)
                        continue;

                    result.Add(first * 100 + second * 10 + third);
                }
                counts[second]++;
            }
            counts[first]++;
        }

        return result.ToArray();
    }
}
