namespace LeetCode.T0501_T1000.T0501_T0600.T0503_NextGreaterElementII;

public class T_NextGreaterElementII
{
    public int[] NextGreaterElements(int[] nums)
    {
        var stack = new Stack<int>();

        var maxIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[maxIndex])
                maxIndex = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var index = (maxIndex + nums.Length - i) % nums.Length;

            while (stack.Count > 0 && stack.Peek() <= nums[index])
                stack.Pop();

            if (stack.Count == 0)
            {
                stack.Push(nums[index]);
                nums[index] = -1;
                continue;
            }

            var peek = stack.Peek();
            stack.Push(nums[index]);
            nums[index] = peek;
        }

        return nums;
    }
}
