namespace LeetCode.T0001_T0500.T0101_T0200.T0118_PascalsTriangle;

public class T_PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>(numRows);
        result.Add([1]);
        if (numRows == 1)
            return result;

        result.Add([1, 1]);

        for (int i = 2; i < numRows; i++)
        {
            var line = new List<int>(i) { 1 };

            for (int j = 1; j < i; j++)
            {
                line.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }

            line.Add(1);
            result.Add(line);
        }

        return result;
    }
}
