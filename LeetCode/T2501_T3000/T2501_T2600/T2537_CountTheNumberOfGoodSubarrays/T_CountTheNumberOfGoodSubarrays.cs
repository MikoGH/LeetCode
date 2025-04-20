namespace LeetCode.T2501_T3000.T2501_T2600.T2537_CountTheNumberOfGoodSubarrays;

public class T_CountTheNumberOfGoodSubarrays
{
    public long CountGood(int[] nums, int k)
    {
        var counts = new Dictionary<int, int>();
        var equalPairs = 0;
        long subarrays = 0;

        var i = 0;
        var j = 0;
        while (i < nums.Length)
        {
            if (!counts.ContainsKey(nums[i]))
                counts[nums[i]] = 0;
            equalPairs += counts[nums[i]];
            counts[nums[i]]++;
            i++;
            while (equalPairs - (counts[nums[j]] - 1) >= k)
            {
                equalPairs -= counts[nums[j]] - 1;
                counts[nums[j]]--;
                j++;
            }
            if (equalPairs >= k)
            {
                subarrays += j + 1;
            }
        }

        return subarrays;
    }
}
