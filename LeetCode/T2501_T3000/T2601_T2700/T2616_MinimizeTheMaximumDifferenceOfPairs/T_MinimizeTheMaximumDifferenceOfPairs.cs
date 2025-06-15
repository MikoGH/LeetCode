namespace LeetCode.T2501_T3000.T2601_T2700.T2616_MinimizeTheMaximumDifferenceOfPairs;

public class T_MinimizeTheMaximumDifferenceOfPairs
{
    public int MinimizeMax(int[] nums, int p)
    {
        if (p == 0)
            return 0;

        Array.Sort(nums);
        int l = -1, r = nums.Max() - nums.Min(), s;

        while (l + 1 < r)
        {
            s = (l + r) >> 1;

            if (Possible(nums, s, p))
                r = s;
            else
                l = s;
        }

        return r;
    }

    private bool Possible(int[] nums, int s, int p)
    {
        int i = 0;
        while (i < nums.Length - 1)
        {
            if (Math.Abs(nums[i] - nums[i + 1]) > s)
            {
                i++;
                continue;
            }

            p--;
            i += 2;
            if (p == 0)
                return true;
        }

        return false;
    }
}
