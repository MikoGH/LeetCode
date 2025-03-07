namespace LeetCode.T2001_T2500.T2161_PartitionArrayAccordingToGivenPivot;

public class T_PartitionArrayAccordingToGivenPivot
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        var result = new int[nums.Length];
        int j = 0, k = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
                result[j++] = nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] > pivot)
                result[k--] = nums[i];
        }

        for (int i = j; i <= k; i++)
        {
            result[j++] = pivot;
        }

        return result;
    }
}
