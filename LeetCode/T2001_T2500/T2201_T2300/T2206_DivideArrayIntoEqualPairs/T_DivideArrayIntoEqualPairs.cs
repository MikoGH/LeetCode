namespace LeetCode.T2001_T2500.T2201_T2300.T2206_DivideArrayIntoEqualPairs;

public class T_DivideArrayIntoEqualPairs
{
    public bool DivideArray(int[] nums)
    {
        var counts = new int[501];

        for (int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
        }

        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] % 2 == 1)
                return false;
        }

        return true;
    }
}
