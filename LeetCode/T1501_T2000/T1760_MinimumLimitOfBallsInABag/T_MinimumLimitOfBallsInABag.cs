namespace LeetCode.T1501_T2000.T1760_MinimumLimitOfBallsInABag;

public class T_MinimumLimitOfBallsInABag
{
    public int MinimumSize(int[] nums, int maxOperations)
    {
        int l = 0, r = (int)1e9;

        while (l + 1 < r)
        {
            int s = (l + r) >> 1;
            if (IsPossible(nums, maxOperations, s))
                r = s;
            else
                l = s;
        }

        return r;
    }

    public bool IsPossible(int[] nums, int maxOperations, int maxBalls)
    {
        int operations = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            operations += ((nums[i] + maxBalls - 1) / maxBalls) - 1;
            if (operations > maxOperations)
                return false;
        }

        return true;
    }
}
