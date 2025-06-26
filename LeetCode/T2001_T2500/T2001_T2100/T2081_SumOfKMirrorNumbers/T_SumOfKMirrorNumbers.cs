namespace LeetCode.T2001_T2500.T2001_T2100.T2081_SumOfKMirrorNumbers;

public class T_SumOfKMirrorNumbers
{
    int[] numsK = new int[400];
    int count = 0;
    long result = 0;

    public long KMirror(int k, int n)
    {
        var even = false;
        long num = 1;
        var prevLog = 1;
        while (count < n)
        {
            var log = (int)Math.Ceiling(Math.Log10(num + 1));

            if (log > prevLog)
            {
                if (even)
                {
                    prevLog++;
                    even = false;
                }
                else
                {
                    even = true;
                    num = (long)Math.Pow(10, prevLog - 1);
                }
            }

            var mirrorNum = num;
            var tmpNum = num;
            if (!even)
                tmpNum /= 10;
            while (tmpNum > 0)
            {
                mirrorNum *= 10;
                mirrorNum += tmpNum % 10;
                tmpNum /= 10;
            }

            if (IsMirrorKBase(mirrorNum, k))
            {
                result += mirrorNum;
                count++;
            }

            num++;
        }

        return result;
    }

    private bool IsMirrorKBase(long num10, int k)
    {
        var len = 0;
        while (num10 > 0)
        {
            numsK[len++] = (int)(num10 % k);
            num10 /= k;
        }

        var i = 0;
        var half = len / 2;

        while (i <= half)
        {
            if (numsK[i] != numsK[len - i - 1])
                return false;
            i++;
        }

        return true;
    }
}
