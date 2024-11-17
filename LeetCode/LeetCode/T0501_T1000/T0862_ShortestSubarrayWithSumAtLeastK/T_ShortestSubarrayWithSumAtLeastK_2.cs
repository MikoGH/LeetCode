namespace LeetCode.T0501_T1000.T0862_ShortestSubarrayWithSumAtLeastK;

public class T_ShortestSubarrayWithSumAtLeastK_2
{
    public int ShortestSubarray(int[] nums, int k)
    {
        var sortedList = new SortedSet<(long, int)>();
        long sum = 0;
        int result = nums.Length + 1;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum >= k && result > i + 1)
                result = i + 1;
            while (sortedList.Count > 0 && sum - sortedList.First().Item1 >= k)
            {
                if (result > i - sortedList.First().Item2)
                    result = i - sortedList.First().Item2;
                sortedList.Remove(sortedList.First());
            }
            sortedList.Add((sum, i));
        }

        if (result == nums.Length + 1)
            return -1;

        return result;
    }
}
