namespace LeetCode.T2001_T2500.T2401_T2500.T2425_BitwiseXOROfAllPairings;

public class T_BitwiseXOROfAllPairings
{
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        var bits = 30;

        var result = 0;
        for (int i = 0; i < bits; i++)
        {
            var sums1 = 0;
            var sums2 = 0;
            for (int j = 0; j < nums1.Length; j++)
            {
                if ((nums1[j] & 1 << i) > 0)
                    sums1++;
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                if ((nums2[j] & 1 << i) > 0)
                    sums2++;
            }

            if ((sums1 * (nums2.Length - sums2) + sums2 * (nums1.Length - sums1)) % 2 == 1)
                result += 1 << i;
        }

        return result;
    }
}
