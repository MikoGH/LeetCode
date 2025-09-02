namespace LeetCode.T0001_T0500.T0301_T0400.T0326_PowerOfThree;

public class T_PowerOfThree
{
    public bool IsPowerOfThree(int n)
    {
        if (n < 1)
            return false;

        while (n > 1)
        {
            if (n % 3 != 0)
                return false;

            n /= 3;
        }

        return true;
    }
}
