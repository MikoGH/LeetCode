namespace LeetCode.T2001_T2500.T2001_T2100.T2040_KthSmallestProductOfTwoSortedArrays;

public class T_KthSmallestProductOfTwoSortedArrays
{
    public long KthSmallestProduct(int[] nums1, int[] nums2, long k)
    {
        if (nums1.Length == 1 && nums2.Length == 1)
            return nums1[0] * nums2[0];

        long l = Math.Min(Math.Min((long)nums1[0] * (long)nums2[0], (long)nums1[^1] * (long)nums2[^1]), Math.Min((long)nums1[0] * (long)nums2[^1], (long)nums1[^1] * (long)nums2[0])) - 1;
        long r = Math.Max(Math.Max((long)nums1[0] * (long)nums2[0], (long)nums1[^1] * (long)nums2[^1]), Math.Max((long)nums1[0] * (long)nums2[^1], (long)nums1[^1] * (long)nums2[0])) + 1;

        while (l + 1 < r)
        {
            long s = (l + r) >> 1;
            if (GetCount(nums1, nums2, s) < k)
                l = s;
            else
                r = s;
        }

        return l + 1;
    }

    private long GetCount(int[] nums1, int[] nums2, long maxProduct)
    {
        long count = 0;

        if (maxProduct == 11)
            count = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums1[i] >= 0)
            {
                int l = -1, r = nums2.Length;
                while (l + 1 < r)
                {
                    int s = (l + r) >> 1;
                    if ((long)nums1[i] * nums2[s] <= maxProduct)
                        l = s;
                    else
                        r = s;
                }
                count += l + 1;
            }
            else
            {
                int l = -1, r = nums2.Length;
                while (l + 1 < r)
                {
                    int s = (l + r) >> 1;
                    if ((long)nums1[i] * nums2[s] <= maxProduct)
                        r = s;
                    else
                        l = s;
                }
                count += (nums2.Length - l - 1);
            }
        }

        return count;
    }
}
