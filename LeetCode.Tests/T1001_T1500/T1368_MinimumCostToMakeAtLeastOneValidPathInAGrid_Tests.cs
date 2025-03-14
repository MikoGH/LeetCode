using LeetCode.T1001_T1500.T1301_T1400.T1368_MinimumCostToMakeAtLeastOneValidPathInAGrid;

namespace LeetCode.Tests.T1001_T1500;

public class T1368_MinimumCostToMakeAtLeastOneValidPathInAGrid_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MinimumCostToMakeAtLeastOneValidPathInAGrid();

        var grid = new int[][]
        {
            new int[] { 1, 1, 3 },
            new int[] { 3, 2, 2 },
            new int[] { 1, 1, 4 }
        };

        var result = taskClass.MinCost(grid);

        var expected = 0;

        Assert.Equal(expected, result);
    }
}
