namespace LeetCode.T0001_T0500.T0201_T0300.T0231_PowerOfTwo;

public class T_PowerOfTwo
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0)
            return false;

        var log = Math.Log2(n);
        var roundedLog = (int)log;

        return log.Equals(roundedLog);
    }
}
