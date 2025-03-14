namespace LeetCode.T3001_T3500.T3001_T3100.T3066_MinimumOperationsToExceedThresholdValueII;

public class T_MinimumOperationsToExceedThresholdValueII
{
    public int MinOperations(int[] nums, int k)
    {
        var queue = new PriorityQueue<long, long>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], nums[i]);
        }

        var operationsCount = 0;
        while (queue.Count >= 2)
        {
            var minElement = queue.Dequeue();
            var maxElement = queue.Dequeue();

            if (minElement >= k)
                break;
            operationsCount++;

            var newElement = (minElement << 1) + maxElement;

            queue.Enqueue(newElement, newElement);
        }

        return operationsCount;
    }
}
