namespace LeetCode.T3001_T3500.T3301_T3400.T3337_TotalCharactersInStringAfterTransformationsII;

public class T_TotalCharactersInStringAfterTransformationsII
{
    const int _alphabetSize = 26;
    const int _mod = (int)1e9 + 7;

    public int LengthAfterTransformations(string s, int t, IList<int> nums)
    {
        var matrix = new int[_alphabetSize][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[_alphabetSize];
        }

        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = 1; j <= nums[i]; j++)
            {
                matrix[(i + j) % _alphabetSize][i] = 1;
            }
        }

        matrix = MultiplyMatrixesExponential(matrix, t);

        var counts = new int[_alphabetSize];
        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'a']++;
        }

        var result = 0;
        for (int i = 0; i < _alphabetSize; i++)
        {
            for (int j = 0; j < _alphabetSize; j++)
            {
                result = (int)((result + (long)matrix[i][j] * counts[j]) % _mod);
            }
        }

        return result;
    }

    private int[][] MultiplyMatrixes(int[][] A, int[][] B)
    {
        var result = new int[_alphabetSize][];
        for (int i = 0; i < _alphabetSize; i++)
            result[i] = new int[_alphabetSize];

        for (int i = 0; i < _alphabetSize; i++)
        {
            for (int j = 0; j < _alphabetSize; j++)
            {
                for (int k = 0; k < _alphabetSize; k++)
                {
                    result[i][j] = (int)((result[i][j] + (long)A[i][k] * B[k][j]) % _mod);
                }
            }
        }

        return result;
    }

    private int[][] MultiplyMatrixesExponential(int[][] matrix, int n)
    {
        var result = new int[_alphabetSize][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[_alphabetSize];
            result[i][i] = 1;
        }

        while (n > 0)
        {
            if (n % 2 == 1)
                result = MultiplyMatrixes(result, matrix);
            matrix = MultiplyMatrixes(matrix, matrix);
            n >>= 1;
        }

        return result;
    }
}
