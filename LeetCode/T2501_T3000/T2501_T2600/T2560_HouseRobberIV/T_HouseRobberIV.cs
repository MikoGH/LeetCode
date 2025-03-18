namespace LeetCode.T2501_T3000.T2501_T2600.T2560_HouseRobberIV;

public class T_HouseRobberIV
{
    public int MinCapability(int[] nums, int k)
    {
        int l = -1;
        int r = nums.Max();

        while (l + 1 < r)
        {
            var s = (l + r) >> 1;
            if (Check(nums, k, s))
                r = s;
            else
                l = s;
        }

        return r;
    }

    private bool Check(int[] nums, int k, int s)
    {
        int i = 0;
        int count = 0;

        while (i < nums.Length)
        {
            if (nums[i] <= s)
            {
                count++;
                i++;
            }
            if (count == k)
                return true;
            i++;
        }

        return false;
    }
}
