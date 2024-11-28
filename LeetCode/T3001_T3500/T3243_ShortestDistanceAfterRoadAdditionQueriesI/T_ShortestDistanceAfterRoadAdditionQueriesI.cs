namespace LeetCode.T3001_T3500.T3243_ShortestDistanceAfterRoadAdditionQueriesI;

public class T_ShortestDistanceAfterRoadAdditionQueriesI
{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        var dp = new int[n][];

        for (int i = 0; i < n; i++)
        {
            dp[i] = new int[queries.Length];
        }

        for (int j = 0; j < queries.Length; j++)
        {
            for (int i = 1; i < n; i++)
            {
                dp[i][j] = dp[i - 1][j] + 1;
                if (j > 0 && dp[i][j - 1] < dp[i][j])
                    dp[i][j] = dp[i][j - 1];
                for (int queryIndex = 0; queryIndex <= j; queryIndex++)
                    if (queries[queryIndex][1] == i)
                    {
                        if (dp[queries[queryIndex][0]][j] + 1 < dp[i][j])
                            dp[i][j] = dp[queries[queryIndex][0]][j] + 1;
                    }
            }
        }

        return dp[n - 1];
    }
}
