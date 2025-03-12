using LeetCode.T3001_T3500.T3208_AlternatingGroupsII;

namespace LeetCode.Tests.T3001_T3500;

public class T3208_AlternatingGroupsII_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_AlternatingGroupsII();

        var colors = new int[] { 1, 1, 0, 1 };

        var k = 4;

        var result = taskClass.NumberOfAlternatingGroups(colors, k);

        var expected = 0;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_AlternatingGroupsII();

        var colors = new int[] { 0, 1, 0, 0, 1, 0, 1 };

        var k = 6;

        var result = taskClass.NumberOfAlternatingGroups(colors, k);

        var expected = 2;

        Assert.Equal(expected, result);
    }
}
