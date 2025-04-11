namespace LeetCode.T2501_T3000.T2801_T2900.T2843_CountSymmetricIntegers;

public class T_CountSymmetricIntegers
{
    public int CountSymmetricIntegers(int low, int high)
    {
        var result = 0;

        for (int i = low; i <= high; i++)
        {
            var digits = (int)Math.Ceiling(Math.Log(i, 10));
            var odd = digits % 2 == 1;
            if (odd)
                continue;
            var half = digits / 2;

            var left = 0;
            var right = 0;

            var num = i;

            for (int j = 0; j < half; j++)
            {
                right += num % 10;
                num /= 10;
            }
            for (int j = 0; j < half; j++)
            {
                left += num % 10;
                num /= 10;
            }

            if (left == right)
                result++;
        }

        return result;
    }
}
