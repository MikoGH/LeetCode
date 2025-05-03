namespace LeetCode.T1001_T1500.T1201_T1300.T1295_FindNumbersWithEvenNumberOfDigits;

public class T_FindNumbersWithEvenNumberOfDigits
{
    public int FindNumbers(int[] nums)
    {
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 9 && Math.Floor(Math.Log10(nums[i])) % 2 == 1)
                count++;
        }

        return count;
    }
}
