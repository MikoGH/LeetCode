namespace LeetCode.T1501_T2000.T1501_T1600.T1504_CountSubmatricesWithAllOnes;

public class T_CountSubmatricesWithAllOnes
{
    public int NumSubmat(int[][] mat)
    {
        var heights = new int[mat.Length + 1, mat[0].Length + 1];

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 0)
                    continue;
                heights[i + 1, j + 1] = 1 + heights[i, j + 1];
            }
        }

        var result = 0;

        for (int i = 1; i < mat.Length + 1; i++)
        {
            for (int j = 1; j < mat[0].Length + 1; j++)
            {
                if (mat[i - 1][j - 1] == 0)
                    continue;

                var min = heights[i, j];
                for (var k = j; k >= 0; k--)
                {
                    if (heights[i, k] == 0)
                        break;

                    if (heights[i, k] < min)
                        min = heights[i, k];

                    result += min;
                }
            }
        }

        return result;
    }
}
