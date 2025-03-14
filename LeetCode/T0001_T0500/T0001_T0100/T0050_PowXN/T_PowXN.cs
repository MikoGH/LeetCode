namespace LeetCode.T0001_T0500.T0001_T0100.T0050_PowXN;

public class T_PowXN
{
    public double MyPow(double x, int n)
    {
        double result = 1;
        var positive = n >= 0;
        long pow = n < 0 ? -1L * n : n;
        while (pow > 0)
        {
            if (pow % 2 == 1)
                result = result * x;
            x = x * x;
            pow >>= 1;
        }

        if (positive)
            return result;

        return 1 / result;
    }
}
