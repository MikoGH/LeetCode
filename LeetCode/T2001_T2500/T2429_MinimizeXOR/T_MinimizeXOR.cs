namespace LeetCode.T2001_T2500.T2429_MinimizeXOR;

public class T_MinimizeXOR
{
    public int MinimizeXor(int num1, int num2)
    {
        int countBitsNum1 = CountBits(num1);
        int countBitsNum2 = CountBits(num2);

        var result = 0;
        if (countBitsNum1 >= countBitsNum2)
        {
            int i = 0;
            while (countBitsNum2 < countBitsNum1)
            {
                if (num1 % 2 == 1)
                    countBitsNum1--;
                num1 >>= 1;
                i++;
            }
            while (num1 > 0)
            {
                if (num1 % 2 == 1)
                    result += 1 << i;
                num1 >>= 1;
                i++;
            }
        }
        else
        {
            var i = 0;
            while (num1 > 0 || countBitsNum1 < countBitsNum2)
            {
                if (num1 % 2 == 1)
                    result += 1 << i;
                else
                {
                    if (countBitsNum1 < countBitsNum2)
                    {
                        result += 1 << i;
                        countBitsNum2--;
                    }
                }
                num1 >>= 1;
                i++;
            }
        }

        return result;
    }

    private int CountBits(int num)
    {
        int count = 0;
        while (num > 0)
        {
            if (num % 2 == 1)
                count++;
            num >>= 1;
        }

        return count;
    }
}
