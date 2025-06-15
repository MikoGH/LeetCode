namespace LeetCode.T0501_T1000.T0901_T1000.T0909_SnakesAndLadders;

public class T_SnakesAndLadders
{
    public int SnakesAndLadders(int[][] board)
    {
        var n = board.Length;
        var line = new int[n*n];
        var pos = 0;
        for (int k = n - 1; k >= 0; k--)
        {
            if ((n - k) % 2 == 0)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    line[pos++] = board[k][j];
                }
            }
            else
            {
                for (int j = 0; j < n; j++)
                {
                    line[pos++] = board[k][j];
                }
            }
        }

        var dp = new int[n*n];
        Array.Fill(dp, -1);
        dp[0] = 0;
        var i = 0;
        while (i < dp.Length)
        {
            if (dp[i] == -1)
            {
                i++;
                continue;
            }

            var f = true;
            for (int j = 1; j <= Math.Min(6, n*n - i - 1); j++)
            {
                if (dp[i + j] == -1 || dp[i] + 1 < dp[i + j])
                {
                    if (line[i + j] != -1)
                    {
                        if (dp[line[i + j] - 1] == -1 || dp[i] + 1 < dp[line[i + j] - 1])
                        {
                            dp[line[i + j] - 1] = dp[i] + 1;
                            if (line[i + j] - 1 < i)
                            {
                                i = line[i + j] - 1;
                                f = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        dp[i + j] = dp[i] + 1;
                    }
                }
            }
            if (f)
                i++;
        }

        if (dp[^1] == -1)
            return -1;

        return dp[^1];
    }
}
