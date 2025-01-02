namespace LeetCode.T0501_T1000.T0983_MinimumCostForTickets;

public class T_MinimumCostForTickets
{
    public int MincostTickets(int[] days, int[] costs)
    {
        var dp = new int[days[^1] + 31];
        var currentDay = 0;

        for (int i = 30; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1];

            if (i - 30 != days[currentDay])
                continue;

            currentDay++;

            dp[i] += costs[0];
            if (dp[i - 7] + costs[1] < dp[i])
                dp[i] = dp[i - 7] + costs[1];
            if (dp[i - 30] + costs[2] < dp[i])
                dp[i] = dp[i - 30] + costs[2];
        }

        return dp[^1];
    }
}
