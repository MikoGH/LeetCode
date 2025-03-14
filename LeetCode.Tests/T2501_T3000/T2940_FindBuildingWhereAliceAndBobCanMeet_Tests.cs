using LeetCode.T2501_T3000.T2901_T3000.T2940_FindBuildingWhereAliceAndBobCanMeet;

namespace LeetCode.Tests.T2501_T3000;

public class T2940_FindBuildingWhereAliceAndBobCanMeet_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_FindBuildingWhereAliceAndBobCanMeet();

        var heights = new int[] { 5, 3, 8, 2, 6, 1, 4, 6 };

        var queries = new int[5][]
        {
            new int[] { 0, 7 },
            new int[] { 3, 5 },
            new int[] { 5, 2 },
            new int[] { 3, 0 },
            new int[] { 1, 6 }
        };

        var result = taskClass.LeftmostBuildingQueries(heights, queries);

        var expected = new int[] { 7, 6, -1, 4, 6 };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_FindBuildingWhereAliceAndBobCanMeet();

        var heights = new int[] { 6, 4, 8, 5, 2, 7 };

        var queries = new int[5][]
        {
            new int[] { 0, 1 },
            new int[] { 0, 3 },
            new int[] { 2, 4 },
            new int[] { 3, 4 },
            new int[] { 2, 2 }
        };

        var result = taskClass.LeftmostBuildingQueries(heights, queries);

        var expected = new int[] { 2, 5, -1, 5, 2 };

        Assert.Equal(expected, result);
    }
}
