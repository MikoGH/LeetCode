using System.Collections;

namespace LeetCode.T3001_T3500.T3011_FindIfArrayCanBeSorted;

public class T_FindIfArrayCanBeSorted
{
    public bool CanSortArray(int[] nums)
    {
        //var bitCounts = nums
        //    .Select(num => new BitArray(new int[] {num})
        //        .Cast<bool>()
        //        .Where(bit => bit)
        //        .Count())
        //    .ToArray();
        byte[] bitCounts = nums
            .Select(i => (byte)Enumerable.Range(0, 16)
                .Where(j => (1 << j & i) > 0)
                .Count())
            .ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    if (bitCounts[j] != bitCounts[j + 1])
                        return false;
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    (bitCounts[j], bitCounts[j + 1]) = (bitCounts[j + 1], bitCounts[j]);
                }
            }
        }
        return true;
    }
}
