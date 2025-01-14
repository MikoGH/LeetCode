namespace LeetCode.T2501_T3000.T2657_FindThePrefixCommonArrayOfTwoArrays;

public class T_FindThePrefixCommonArrayOfTwoArrays
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        var nums = new bool[A.Length + 1];
        var result = new int[A.Length];

        var count = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (nums[A[i]])
                count++;
            nums[A[i]] = true;
            if (nums[B[i]])
                count++;
            nums[B[i]] = true;
            result[i] = count;
        }

        return result;
    }
}
