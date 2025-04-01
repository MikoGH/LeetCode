namespace LeetCode.T2501_T3000.T2501_T2600.T2551_PutMarblesInBags;

public class T_PutMarblesInBags
{
    public long PutMarbles(int[] weights, int k)
    {
        var borderSums = new int[weights.Length - 1];
        for (int i = 0; i < weights.Length - 1; i++)
        {
            borderSums[i] = weights[i] + weights[i + 1];
        }

        Array.Sort(borderSums);

        long minimumScore = weights[0] + weights[weights.Length - 1];
        long maximumScore = weights[0] + weights[weights.Length - 1];

        for (int i = 0; i < k - 1; i++)
        {
            minimumScore += borderSums[i];
            maximumScore += borderSums[borderSums.Length - i - 1];
        }

        return maximumScore - minimumScore;
    }
}
