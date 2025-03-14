namespace LeetCode.T2001_T2500.T2301_T2400.T2342_MaxSumOfAPairWithEqualSumOfDigits;

public class T_MaxSumOfAPairWithEqualSumOfDigits
{
    public int MaximumSum(int[] nums)
    {
        var maxNumByDigitSum = new Dictionary<int, int>();
        var maxSum = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            var digitSum = 0;
            var num = nums[i];
            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            if (!maxNumByDigitSum.TryGetValue(digitSum, out int value))
            {
                maxNumByDigitSum.Add(digitSum, nums[i]);
                continue;
            }

            var sum = value + nums[i];
            if (sum > maxSum)
                maxSum = sum;

            if (value < nums[i])
            {
                maxNumByDigitSum[digitSum] = nums[i];
            }
        }

        return maxSum;
    }
}
