namespace LeetCode.T0001_T0500.T0301_T0400.T0342_PowerOfFour;

public class T_PowerOfFour
{
    public bool IsPowerOfFour(int n)
    {
        if (n < 1)
            return false;

        while (n > 1)
        {
            if (n % 4 != 0)
                return false;

            n /= 4;
        }

        return true;
    }
}
