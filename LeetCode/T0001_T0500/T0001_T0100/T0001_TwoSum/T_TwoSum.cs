namespace LeetCode.T0001_T0500.T0001_T0100.T0001_TwoSum;

public class T_TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
                return [map[target - nums[i]], i];

            map[nums[i]] = i;
        }
        return [];
    }
}
