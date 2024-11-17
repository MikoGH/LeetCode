namespace LeetCode.T3001_T3500.T3133_MinimumArrayEnd;

public class T_MinimumArrayEnd
{
    public long MinEnd(int n, int x)
    {
        var k = n - 1;
        int j = 0;
        long result = 0;
        for (int i = 0; i < 63; i++)
        {
            if (((long)1 << i & x) > 0)
            {
                result += (long)1 << i;
                continue;
            }
            if ((k & (long)1 << j) > 0)
                result += (long)1 << i;
            j++;
        }

        return result;
    }
}
