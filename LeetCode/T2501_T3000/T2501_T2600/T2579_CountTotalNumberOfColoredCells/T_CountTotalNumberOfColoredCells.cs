namespace LeetCode.T2501_T3000.T2501_T2600.T2579_CountTotalNumberOfColoredCells;

public class T_CountTotalNumberOfColoredCells
{
    public long ColoredCells(int n)
    {
        long n1 = n;
        return n1 * n1 + (n1 - 1) * (n1 - 1);
    }
}
