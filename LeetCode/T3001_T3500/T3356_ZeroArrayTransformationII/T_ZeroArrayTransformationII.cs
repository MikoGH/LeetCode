namespace LeetCode.T3001_T3500.T3356_ZeroArrayTransformationII;

public class T_ZeroArrayTransformationII
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        var decreases = new int[nums.Length + 1];

        int l = -1;
        int r = queries.Length + 1;
        while (l + 1 < r)
        {
            var s = (l + r) >> 1;
            if (!Check(nums, queries, s, decreases))
                l = s;
            else
                r = s;
        }

        if (r == queries.Length + 1)
            return -1;

        return r;
    }

    private bool Check(int[] nums, int[][] queries, int s, int[] decreases)
    {
        Array.Clear(decreases);

        for (int i = 0; i < s; i++)
        {
            decreases[queries[i][0]] += queries[i][2];
            decreases[queries[i][1] + 1] -= queries[i][2];
        }

        var decreaseBy = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            decreaseBy += decreases[i];
            if (nums[i] - decreaseBy > 0)
                return false;
        }

        return true;
    }
}
