namespace LeetCode.T1501_T2000.T1701_T1800.T1752_CheckIfArrayIsSortedAndRotated;

public class T_CheckIfArrayIsSortedAndRotated
{
    public bool Check(int[] nums)
    {
        var startsInside = false;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                if (startsInside)
                    return false;

                startsInside = true;
            }
        }

        if (startsInside && nums[^1] > nums[0])
            return false;

        return true;
    }
}
