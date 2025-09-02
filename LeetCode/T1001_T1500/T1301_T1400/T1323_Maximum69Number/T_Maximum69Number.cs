namespace LeetCode.T1001_T1500.T1301_T1400.T1323_Maximum69Number;

public class T_Maximum69Number
{
    public int Maximum69Number(int num)
    {
        var curr = num;

        int i = 0;
        int add = 0;
        while (curr > 0)
        {
            if (curr % 10 == 6)
                add = 3 * (int)Math.Pow(10, i);

            curr /= 10;
            i++;
        }

        return num + add;
    }
}
