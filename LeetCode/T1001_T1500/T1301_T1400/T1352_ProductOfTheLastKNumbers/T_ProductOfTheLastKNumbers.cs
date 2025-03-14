namespace LeetCode.T1001_T1500.T1301_T1400.T1352_ProductOfTheLastKNumbers;

public class T_ProductOfTheLastKNumbers
{
    private readonly int[] pref = new int[40000];
    private int index = 0;

    public T_ProductOfTheLastKNumbers()
    {
        pref[0] = 1;
    }

    public void Add(int num)
    {
        if (num == 0)
        {
            index = 0;
            return;
        }
        index++;
        pref[index] = pref[index - 1] * num;
    }

    public int GetProduct(int k)
    {
        if (k > index)
            return 0;
        return pref[index] / pref[index - k];
    }
}
