namespace LeetCode.T0501_T1000.T0801_T0900.T0862_ShortestSubarrayWithSumAtLeastK;

public class T_ShortestSubarrayWithSumAtLeastK_3
{
    public int ShortestSubarray(int[] nums, int k)
    {
        var prefix = new long[nums.Length + 1];
        prefix[0] = 0;
        for (int i = 1; i < prefix.Length; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i - 1];
        }

        var linkedList = new LinkedList<int>();
        int result = nums.Length + 1;
        for (int i = 0; i < prefix.Length; i++)
        {
            while (linkedList.Count > 0 && prefix[i] - prefix[linkedList.First.Value] >= k)
            {
                if (result > i - linkedList.First.Value)
                    result = i - linkedList.First.Value;
                linkedList.RemoveFirst();
            }
            while (linkedList.Count > 0 && prefix[i] <= prefix[linkedList.Last.Value])
            {
                linkedList.RemoveLast();
            }
            linkedList.AddLast(i);
        }

        return result == nums.Length + 1 ? -1 : result;
    }
}
