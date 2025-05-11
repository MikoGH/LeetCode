namespace LeetCode.T2501_T3000.T2901_T3000.T2918_MinimumEqualSumOfTwoArraysAfterReplacingZeros;

public class T_MinimumEqualSumOfTwoArraysAfterReplacingZeros
{
    public long MinSum(int[] nums1, int[] nums2)
    {
        long sum1 = 0;
        long sum2 = 0;
        int countZeros1 = 0;
        int countZeros2 = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            sum1 += nums1[i];
            if (nums1[i] == 0)
                countZeros1++;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            sum2 += nums2[i];
            if (nums2[i] == 0)
                countZeros2++;
        }

        sum1 += countZeros1;
        sum2 += countZeros2;

        if (sum2 > sum1)
        {
            if (countZeros1 == 0)
                return -1;
            else
                return sum2;
        }
        else if (sum2 < sum1)
        {
            if (countZeros2 == 0)
                return -1;
            else
                return sum1;
        }
        else
        {
            return sum1;
        }
    }
}
