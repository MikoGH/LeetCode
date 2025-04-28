namespace LeetCode.T2501_T3000.T2801_T2900.T2845_CountOfInterestingSubarrays;

public class T_CountOfInterestingSubarrays
{
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
    {
        if (modulo == 1)
            return GetCombinations(nums.Count);

        var positions = new List<int>() { -1 };

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % modulo == k)
            {
                positions.Add(i);
            }
        }
        positions.Add(nums.Count);

        long result = 0;
        for (int left = 1; left < positions.Count; left++)
        {
            var right = k == 0 ? left + modulo : left + k;
            while (right < positions.Count)
            {
                result += (positions[left] - positions[left - 1]) * (positions[right] - positions[right - 1]);
                right += modulo;
            }
        }

        if (k == 0)
        {
            for (int i = 1; i < positions.Count; i++)
            {
                result += GetCombinations(positions[i] - positions[i - 1] - 1);
            }
        }

        return result;
    }

    private long GetCombinations(int n)
    {
        if (n % 2 == 0)
            return (long)(n / 2) * (n + 1);

        return (long)(n / 2) * (n + 1) + n / 2 + 1;
    }
}
