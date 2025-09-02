namespace LeetCode.T1001_T1500.T1201_T1300.T1277_CountSquareSubmatricesWithAllOne;

public class T_CountSquareSubmatricesWithAllOne
{
    public int CountSquares(int[][] matrix)
    {
        var dp = new int[matrix.Length + 1, matrix[0].Length + 1];

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                dp[i + 1, j + 1] = matrix[i][j] + dp[i, j + 1] + dp[i + 1, j] - dp[i, j];
            }
        }

        var result = 0;

        for (int i = 1; i < matrix.Length + 1; i++)
        {
            for (int j = 1; j < matrix[0].Length + 1; j++)
            {
                if (matrix[i - 1][j - 1] == 0)
                    continue;

                result += BinarySearch(dp, i, j);
            }
        }

        return result;
    }

    private int BinarySearch(int[,] dp, int i, int j)
    {
        var l = 1;
        var r = Math.Min(i, j) + 1;

        while (l + 1 < r)
        {
            var s = (l + r) >> 1;
            if (IsAllOnes(dp, i, j, s))
                l = s;
            else
                r = s;
        }

        return l;
    }

    private bool IsAllOnes(int[,] dp, int i, int j, int s)
    {
        return dp[i, j] - dp[i - s, j] - dp[i, j - s] + dp[i - s, j - s] == s * s;
    }
}
