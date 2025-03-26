namespace LeetCode.T2001_T2500.T2001_T2100.T2033_MinimumOperationsToMakeAUniValueGrid;

public class T_MinimumOperationsToMakeAUniValueGrid
{
    public int MinOperations(int[][] grid, int x)
    {
        var orderedValues = grid.SelectMany(x => x).Order().ToList();

        var median = orderedValues[orderedValues.Count >> 1];

        var count = 0;

        foreach (var value in orderedValues)
        {
            var diff = Math.Abs(value - median);
            if (diff % x != 0)
                return -1;

            count += diff / x;
        }

        return count;
    }
}
