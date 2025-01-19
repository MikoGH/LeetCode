namespace LeetCode.T3001_T3500.T3424_MinimumCostToMakeArraysIdentical;

public class T_MinimumCostToMakeArraysIdentical
{
    public long MinCost(int[] arr, int[] brr, long k)
    {
        long resultOriginal = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var abs = Math.Abs(arr[i] - brr[i]);
            resultOriginal += abs;
        }

        Array.Sort(arr);
        Array.Sort(brr);

        long result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var abs = Math.Abs(arr[i] - brr[i]);
            result += abs;
        }

        if (resultOriginal > result + k)
            return result + k;

        return resultOriginal;
    }
}
