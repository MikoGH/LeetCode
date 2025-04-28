namespace LeetCode.T2001_T2500.T2401_T2500.T2444_CountSubarraysWithFixedBounds;

public class T_CountSubarraysWithFixedBounds
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        long count = 0;
        var left = 0;

        var asc = new Stack<int>();
        var desc = new Stack<int>();
        var ascFirst = 0;
        var descFirst = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minK || nums[i] > maxK)
            {
                asc.Clear();
                desc.Clear();
                left = i + 1;
                continue;
            }

            while (asc.Any() && nums[asc.Peek()] >= nums[i])
                asc.Pop();
            if (asc.Count == 0)
                ascFirst = i;
            asc.Push(i);

            while (desc.Any() && nums[desc.Peek()] <= nums[i])
                desc.Pop();
            if (desc.Count == 0)
                descFirst = i;
            desc.Push(i);

            if (nums[ascFirst] == minK && nums[descFirst] == maxK)
            {
                var start = Math.Min(ascFirst, descFirst);
                count += start - left + 1;
            }
        }

        return count;
    }
}
