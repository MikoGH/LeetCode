namespace LeetCode.T0001_T0500.T0401_T0500.T0498_DiagonalTraverse;

public class T_DiagonalTraverse
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        var result = new int[mat.Length * mat[0].Length];

        if (mat[0].Length == 1)
        {
            for (int i1 = 0; i1 < mat.Length; i1++)
                result[i1] = mat[i1][0];

            return result;
        }

        if (mat.Length == 1)
        {
            for (int j1 = 0; j1 < mat[0].Length; j1++)
                result[j1] = mat[0][j1];

            return result;
        }

        var d = true;
        var index = 0;
        var i = 0;
        var j = 0;
        var f = true;
        while (i < mat.Length - 1 || j < mat[0].Length - 1)
        {
            result[index++] = mat[i][j];

            if (f && i == mat.Length - 1)
            {
                j++;
                d = !d;
                f = false;
                continue;
            }
            if (f && j == mat[0].Length - 1)
            {
                i++;
                d = !d;
                f = false;
                continue;
            }
            if (f && i == 0)
            {
                j++;
                d = !d;
                f = false;
                continue;
            }
            if (f && j == 0)
            {
                i++;
                d = !d;
                f = false;
                continue;
            }
            f = true;
            if (!d)
            {
                i++;
                j--;
                continue;
            }
            i--;
            j++;
        }
        result[index++] = mat[i][j];

        return result;
    }
}
