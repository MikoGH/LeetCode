namespace LeetCode.T0001_T0500.T0101_T0200.T0135_Candy;

public class T_Candy
{
    public int Candy(int[] ratings)
    {
        var candies = new int[ratings.Length];
        candies[0] = 1;
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
                candies[i] = candies[i - 1] + 1;
            else
                candies[i] = 1;
        }

        var count = candies[^1];
        for (int i = ratings.Length - 1; i > 0; i--)
        {
            if (ratings[i - 1] > ratings[i])
            {
                candies[i - 1] = Math.Max(candies[i] + 1, candies[i - 1]);
            }
            count += candies[i - 1];
        }

        return count;
    }
}
