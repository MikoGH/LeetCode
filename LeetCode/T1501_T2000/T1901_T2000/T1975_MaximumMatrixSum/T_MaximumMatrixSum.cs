namespace LeetCode.T1501_T2000.T1901_T2000.T1975_MaximumMatrixSum;

public class T_MaximumMatrixSum
{
    public long MaxMatrixSum(int[][] matrix)
    {
        int countMinus = 0;
        int minElement = (int)1e5;
        long sum = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                int abs = matrix[i][j] < 0 ? -matrix[i][j] : matrix[i][j];
                sum += abs;
                if (abs < minElement)
                    minElement = abs;
                if (matrix[i][j] < 0)
                    countMinus++;
            }
        }

        if (countMinus % 2 == 0)
            return sum;

        return sum - 2 * minElement;
    }
}
