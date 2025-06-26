namespace LeetCode.T2001_T2500.T2201_T2300.T2200_FindAllKDistantIndicesInAnArray;

public class T_FindAllKDistantIndicesInAnArray
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != key)
                continue;

            
            for (int j = Math.Max(result.Count == 0 ? 0 : result[^1] + 1, i - k); j <= Math.Min(i + k, nums.Length - 1); j++)
            {
                result.Add(j);
            }
        }

        return result;
    }
}
