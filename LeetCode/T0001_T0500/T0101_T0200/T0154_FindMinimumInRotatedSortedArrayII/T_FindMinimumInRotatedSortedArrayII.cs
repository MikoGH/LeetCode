namespace LeetCode.T0001_T0500.T0101_T0200.T0154_FindMinimumInRotatedSortedArrayII;

public class T_FindMinimumInRotatedSortedArrayII
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        int s;
        while (l + 1 < r)
        {
            s = l + r >> 1;
            if (nums[l] < nums[r])
                if (nums[s] < nums[l])
                    l = s;
                else
                    r = s;
            else if (nums[l] > nums[r])
                if (nums[s] < nums[l])
                    r = s;
                else
                    l = s;
            else
                l++;
        }

        if (nums[r] < nums[l])
            return nums[r];
        return nums[l];
    }
}
