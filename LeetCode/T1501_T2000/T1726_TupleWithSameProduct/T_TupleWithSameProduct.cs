namespace LeetCode.T1501_T2000.T1726_TupleWithSameProduct;

public class T_TupleWithSameProduct
{
    public int TupleSameProduct(int[] nums)
    {
        var dct = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                var p = nums[i] * nums[j];
                if (!dct.ContainsKey(p))
                    dct.Add(p, 0);
                dct[p]++;
            }
        }

        var result = 0;
        foreach (var value in dct.Values)
        {
            result += GetSum(value - 1);
        }

        return result * 8;
    }

    private int GetSum(int value)
    {
        if (value % 2 == 0)
            return (value + 1) * (value >> 1);

        return (value + 1) * (value >> 1) + (value >> 1) + 1;
    }
}
