namespace LeetCode.T3001_T3500.T3301_T3400.T3396_MinimumNumberOfOperationsToMakeElementsInArrayDistinct;

public class T_MinimumNumberOfOperationsToMakeElementsInArrayDistinct
{
    public int MinimumOperations(int[] nums)
    {
        var iterations = (nums.Length + 2) / 3;
        var counts = new bool[101];

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (counts[nums[i]])
                break;

            counts[nums[i]] = true;
            if (i % 3 == 0)
                iterations--;
        }

        return iterations;
    }
}
