using LeetCode.T3001_T3500.T3201_T3300.T3243_ShortestDistanceAfterRoadAdditionQueriesI;

namespace LeetCode.Tests.T3001_T3500;

public class T3243_ShortestDistanceAfterRoadAdditionQueriesI_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ShortestDistanceAfterRoadAdditionQueriesI();

        int n = 5;

        var matrix = new int[3][]
        {
            new int[] { 2, 4 },
            new int[] { 0, 2 },
            new int[] { 0, 4 }
        };

        var result = taskClass.ShortestDistanceAfterQueries(n, matrix);

        var expected = new int[3] { 3, 2, 1 };

        Assert.Equal(expected, result);
    }
}
