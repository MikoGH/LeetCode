namespace LeetCode.T2001_T2500.T2001_T2100.T2099_FindSubsequenceOfLengthKWithTheLargestSum;

public class T_FindSubsequenceOfLengthKWithTheLargestSum
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        var dct = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dct.TryAdd(nums[i], 0);
            dct[nums[i]]++;
        }

        var orderedKeys = dct.Keys.OrderDescending().ToList();

        var count = k;

        foreach (var key in orderedKeys)
        {
            if (count == 0)
                dct[key] = 0;
            else
            {
                if (count < dct[key])
                    dct[key] = count;

                count -= dct[key];
            }
        }

        var result = new int[k];

        for (int i = 0; i < nums.Length; i++)
        {
            if (dct[nums[i]] > 0)
            {
                result[count++] = nums[i];
                dct[nums[i]]--;
            }
        }

        return result;
    }
}
