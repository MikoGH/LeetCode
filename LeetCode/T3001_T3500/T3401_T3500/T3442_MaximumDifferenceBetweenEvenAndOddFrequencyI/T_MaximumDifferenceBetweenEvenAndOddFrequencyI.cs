namespace LeetCode.T3001_T3500.T3401_T3500.T3442_MaximumDifferenceBetweenEvenAndOddFrequencyI;

public class T_MaximumDifferenceBetweenEvenAndOddFrequencyI
{
    public int MaxDifference(string s)
    {
        var counts = new int[26];

        foreach (var smb in s)
        {
            counts[smb - 'a']++;
        }

        var maxOdd = 0;
        var minEven = 0;

        for (int i = 0; i < counts.Length; i ++)
        {
            if (counts[i] == 0)
                continue;

            if (counts[i] % 2 == 0)
            {
                if (counts[i] < minEven || minEven == 0)
                    minEven = counts[i];
            }
            else
            {
                if (counts[i] > maxOdd)
                    maxOdd = counts[i];
            }
        }

        if (maxOdd == 0 || minEven == 0)
            return - 1;

        return maxOdd - minEven;
    }
}
