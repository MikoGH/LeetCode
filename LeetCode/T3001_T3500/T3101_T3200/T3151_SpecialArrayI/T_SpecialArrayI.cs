namespace LeetCode.T3001_T3500.T3101_T3200.T3151_SpecialArrayI;

public class T_SpecialArrayI
{
    public bool IsArraySpecial(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] % 2 == nums[i + 1] % 2)
                return false;
        }

        return true;
    }
}
