namespace LeetCode.T1501_T2000.T1701_T1800.T1751_MaximumNumberOfEventsThatCanBeAttendedII;

public class T_MaximumNumberOfEventsThatCanBeAttendedII
{
    public int MaxValue(int[][] events, int k)
    {
        Array.Sort(events, (a, b) => a[0].CompareTo(b[0]));

        var dp = new int[k + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[events.Length];
            Array.Fill(dp[i], -1);
        }

        var result = Dfs(events, dp, 0, k);

        return result;
    }

    private int Dfs(int[][] events, int[][] dp, int pos, int count)
    {
        if (count == 0 || pos == events.Length)
            return 0;

        if (dp[count][pos] != -1)
            return dp[count][pos];

        int nextPos = BinarySearch(events, events[pos][1]);
        dp[count][pos] = Math.Max(Dfs(events, dp, pos + 1, count), events[pos][2] + Dfs(events, dp, nextPos, count - 1));

        return dp[count][pos];
    }

    private int BinarySearch(int[][] events, int target)
    {
        int left = 0, right = events.Length;
        while (left + 1 < right)
        {
            var s = (left + right) >> 1;
            if (events[s][0] <= target)
                left = s;
            else
                right = s;
        }

        return right;
    }
}
