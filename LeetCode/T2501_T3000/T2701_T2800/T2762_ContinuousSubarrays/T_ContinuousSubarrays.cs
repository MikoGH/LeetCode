namespace LeetCode.T2501_T3000.T2701_T2800.T2762_ContinuousSubarrays;

public class T_ContinuousSubarrays
{
    public long ContinuousSubarrays(int[] nums)
    {
        var frequency = new SortedDictionary<int, int>();

        int i = 0, j = 0;
        long count = 0;
        while (j < nums.Length)
        {
            if (frequency.Count > 0 && (nums[j] - frequency.First().Key > 2 || frequency.Last().Key - nums[j] > 2))
            {
                frequency[nums[i]]--;
                if (frequency[nums[i]] <= 0)
                    frequency.Remove(nums[i]);
                i++;
                continue;
            }

            if (!frequency.ContainsKey(nums[j]))
                frequency.Add(nums[j], 0);
            frequency[nums[j]]++;
            count += j - i + 1;
            j++;
        }

        return count;
    }
}
