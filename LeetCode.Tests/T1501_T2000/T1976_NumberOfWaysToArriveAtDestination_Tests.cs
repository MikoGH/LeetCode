using LeetCode.T1501_T2000.T1901_T2000.T1976_NumberOfWaysToArriveAtDestination;

namespace LeetCode.Tests.T1501_T2000;

public class T1976_NumberOfWaysToArriveAtDestination_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_NumberOfWaysToArriveAtDestination();

        var n = 7;
        var roads = new int[][] { new int[] { 0, 6, 7 }, new int[] {0, 1, 2}, new int[] {1, 2, 3}, new int[] {1, 3, 3}, new int[] {6, 3, 3}, new int[] {3, 5, 1}, new int[] {6, 5, 1}, new int[] {2, 5, 1}, new int[] {0, 4, 5}, new int[] {4, 6, 2} };

        var result = taskClass.CountPaths(n, roads);

        var expected = 4;

        Assert.Equal(expected, result);
    }
}
