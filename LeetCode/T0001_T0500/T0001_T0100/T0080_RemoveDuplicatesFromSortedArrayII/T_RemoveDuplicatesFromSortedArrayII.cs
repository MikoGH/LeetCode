namespace LeetCode.T0001_T0500.T0001_T0100.T0080_RemoveDuplicatesFromSortedArrayII;

public class T_RemoveDuplicatesFromSortedArrayII
{
    public int RemoveDuplicates(int[] nums)
    {
        var k = 2;

        if (nums.Length < k)
            return nums.Length;

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] > nums[k - 2])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
