namespace LeetCode.T3001_T3500.T3401_T3500.T3452_SumOfGoodNumbers;

public class T_SumOfGoodNumbers
{
    public int SumOfGoodNumbers(int[] nums, int k)
    {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if ((i - k < 0 || nums[i] > nums[i - k]) && (i + k >= nums.Length || nums[i + k] < nums[i]))
                sum += nums[i];
        }

        return sum;
    }
}
