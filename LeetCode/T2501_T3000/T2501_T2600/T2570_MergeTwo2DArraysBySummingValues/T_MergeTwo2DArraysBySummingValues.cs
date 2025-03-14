namespace LeetCode.T2501_T3000.T2501_T2600.T2570_MergeTwo2DArraysBySummingValues;

public class T_MergeTwo2DArraysBySummingValues
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        int i = 0, j = 0;

        var result = new List<int[]>(Math.Max(nums1.Length, nums2.Length));

        while (i < nums1.Length || j < nums2.Length)
        {
            if (i < nums1.Length && j < nums2.Length && nums1[i][0] < nums2[j][0] || j == nums2.Length)
            {
                result.Add(nums1[i]);
                i++;
                continue;
            }

            if (i < nums1.Length && j < nums2.Length && nums1[i][0] > nums2[j][0] || i == nums1.Length)
            {
                result.Add(nums2[j]);
                j++;
                continue;
            }

            result.Add(nums1[i]);
            result[^1][1] += nums2[j][1];
            i++;
            j++;
        }

        return result.ToArray();
    }
}
