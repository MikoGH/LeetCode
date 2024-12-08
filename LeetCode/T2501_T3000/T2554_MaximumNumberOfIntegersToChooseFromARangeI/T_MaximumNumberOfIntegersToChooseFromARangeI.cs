namespace LeetCode.T2501_T3000.T2554_MaximumNumberOfIntegersToChooseFromARangeI;

public class T_MaximumNumberOfIntegersToChooseFromARangeI
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        bool[] nums = new bool[n + 1];
        var count = n;
        int s = 0;
        if (n % 2 == 0)
            s = (n + 1) * n / 2;
        else
            s = n * (n / 2) + n;
        for (int i = 0; i < banned.Length; i++)
        {
            if (banned[i] <= n && !nums[banned[i]])
            {
                s -= banned[i];
                nums[banned[i]] = true;
                count--;
            }
        }
        for (int i = n; i > 0; i--)
        {
            if (s <= maxSum)
                break;
            if (!nums[i])
            {
                count--;
                s -= i;
            }
        }

        return count;
    }
}
