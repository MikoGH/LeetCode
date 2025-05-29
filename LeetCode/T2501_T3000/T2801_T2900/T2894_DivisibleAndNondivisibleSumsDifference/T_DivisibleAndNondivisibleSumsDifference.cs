namespace LeetCode.T2501_T3000.T2801_T2900.T2894_DivisibleAndNondivisibleSumsDifference;

public class T_DivisibleAndNondivisibleSumsDifference
{
    public int DifferenceOfSums(int n, int m)
    {
        var countDivisible = n / m;

        return GetSum(n) - 2 * m * GetSum(countDivisible);
    }

    private int GetSum(int value)
    {
        if (value % 2 == 0)
            return (value + 1) * (value >> 1);

        return (value + 1) * (value >> 1) + (value >> 1) + 1;
    }
}
