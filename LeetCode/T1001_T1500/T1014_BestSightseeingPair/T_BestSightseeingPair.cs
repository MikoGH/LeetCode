namespace LeetCode.T1001_T1500.T1014_BestSightseeingPair;

public class T_BestSightseeingPair
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        var result = 0;

        int i = 0, j = 1;
        while (j < values.Length)
        {
            var currentResult = values[i] + values[j] + i - j;
            if (currentResult > result)
                result = currentResult;

            if (values[i] - values[j] <= j - i)
                i = j;
            j++;
        }

        return result;
    }
}
