namespace LeetCode.T2501_T3000.T2779_MaximumBeautyOfAnArrayAfterApplyingOperation;

public class T_MaximumBeautyOfAnArrayAfterApplyingOperation
{
    public int MaximumBeauty(int[] nums, int k)
    {
        int[] numsCount = new int[(int)10e5 + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            numsCount[nums[i]]++;
        }

        int count = 0;
        int result = 0;
        for (int i = 0; i < numsCount.Length; i++)
        {
            count += numsCount[i];
            if (i >= k * 2 + 1)
                count -= numsCount[i - k * 2 - 1];

            if (count > result)
                result = count;
        }

        return result;
    }
}
