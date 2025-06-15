namespace LeetCode.T0001_T0500.T0401_T0500.T0440_KthSmallestInLexicographicalOrder;

public class T_KthSmallestInLexicographicalOrder
{
    public int FindKthNumber(int n, int k)
    {
        var position = 1;
        k--;

        while (k > 0)
        {
            long prefix = position;
            long nextPrefix = prefix + 1;
            int steps = 0;
            while (prefix <= n)
            {
                steps += (int)(Math.Min((long)(n + 1), nextPrefix) - prefix);
                prefix *= 10;
                nextPrefix *= 10;
            }

            if (steps > k)
            {
                position *= 10;
                k--;
            }
            else
            {
                k -= steps;
                position++;
            }
        }

        return position;
    }
}
