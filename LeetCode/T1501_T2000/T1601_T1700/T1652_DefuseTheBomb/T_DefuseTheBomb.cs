namespace LeetCode.T1501_T2000.T1601_T1700.T1652_DefuseTheBomb;

public class T_DefuseTheBomb
{
    public int[] Decrypt(int[] code, int k)
    {
        var length = code.Length;
        var sum = 0;
        var result = new int[length];
        if (k == 0)
            return result;

        if (k > 0)
        {
            for (int i = length + k - 1; i >= 0; i--)
            {
                if (i < length)
                {
                    result[i % length] = sum;
                    sum -= code[(i + k) % length];
                }
                sum += code[i % length];
            }
        }
        else if (k < 0)
        {
            for (int i = 0; i < length - k; i++)
            {
                if (i >= -k)
                {
                    result[i % length] = sum;
                    sum -= code[(i + k) % length];
                }
                sum += code[i % length];
            }
        }

        return result;
    }
}
