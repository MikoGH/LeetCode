namespace LeetCode.T2501_T3000.T2593_FindScoreOfAnArrayAfterMarkingAllElements;

public class T_FindScoreOfAnArrayAfterMarkingAllElements
{
    public long FindScore(int[] nums)
    {
        var queue = new PriorityQueue<(int, int), (int, int)>();
        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue((nums[i], i), (nums[i], i));
        }

        long count = 0;
        while (queue.Count > 0)
        {
            var elm = queue.Dequeue();
            if (nums[elm.Item2] == 0)
                continue;

            count += nums[elm.Item2];
            nums[elm.Item2] = 0;
            if (elm.Item2 - 1 >= 0)
                nums[elm.Item2 - 1] = 0;
            if (elm.Item2 + 1 < nums.Length)
                nums[elm.Item2 + 1] = 0;
        }

        return count;
    }
}
