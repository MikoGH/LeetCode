namespace LeetCode.T2501_T3000.T2701_T2800.T2799_CountCompleteSubarraysInAnArray;

public class T_CountCompleteSubarraysInAnArray
{
    public int CountCompleteSubarrays(int[] nums)
    {
        var counts = new int[2001];
        var totalDistinct = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
            if (counts[nums[i]] == 1)
                totalDistinct++;
        }

        var right = 0;
        var distinct = 0;
        Array.Clear(counts);
        while (distinct < totalDistinct)
        {
            counts[nums[right]]++;
            if (counts[nums[right]] == 1)
                distinct++;
            right++;
        }

        var result = nums.Length - right + 1;

        for (int left = 0; left < nums.Length; left++)
        {
            if (counts[nums[left]] > 1)
            {
                counts[nums[left]]--;
                result += nums.Length - right + 1;
                continue;
            }

            distinct--;
            counts[nums[left]]--;
            while (distinct < totalDistinct && right < nums.Length)
            {
                counts[nums[right]]++;
                if (counts[nums[right]] == 1)
                    distinct++;
                right++;
            }
            if (distinct < totalDistinct)
                break;
            result += nums.Length - right + 1;
        }

        return result;
    }
}
