namespace LeetCode.T3001_T3500.T3264_FinalArrayStateAfterKMultiplicationOperationsI;

public class T_FinalArrayStateAfterKMultiplicationOperationsI
{
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        var queue = new PriorityQueue<int, (int, int)>();
        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(i, (nums[i], i));
        }

        for (int i = 0; i < k; i++)
        {
            var index = queue.Dequeue();
            nums[index] *= multiplier;
            queue.Enqueue(index, (nums[index], index));
        }

        return nums;
    }
}
