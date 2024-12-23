namespace LeetCode.T1001_T1500.T1475_FinalPricesWithASpecialDiscountInAShop;

public class T_FinalPricesWithASpecialDiscountInAShop
{
    public int[] FinalPrices(int[] prices)
    {
        for (int i = 0; i < prices.Length - 1; i++)
        {
            var j = i + 1;
            while (j < prices.Length && prices[j] > prices[i])
                j++;

            if (j == prices.Length)
                continue;

            prices[i] -= prices[j];
        }

        return prices;
    }
}
