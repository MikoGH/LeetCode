namespace LeetCode.T2501_T3000.T2801_T2900.T2873_MaximumValueOfAnOrderedTripletI;

public class T_MaximumValueOfAnOrderedTripletI
{
    public long MaximumTripletValue(int[] nums)
    {
        long maxNum = Math.Max(nums[0], nums[1]);
        long minNum = nums[1];
        long maxDifference = nums[0] - nums[1];
        long result = 0;

        for (var i = 2; i < nums.Length; i++)
        {
            long value = maxDifference * nums[i];
            if (value > result)
                result = value;

            if (nums[i] < minNum)
            {
                minNum = nums[i];
                var difference = maxNum - minNum;
                if (difference > maxDifference)
                    maxDifference = difference;
            }

            if (nums[i] > maxNum)
            {
                maxNum = nums[i];
                minNum = nums[i];
            }
        }

        return result;
    }
}
