using LeetCode.T3001_T3500.T3301_T3400.T3394_CheckIfGridCanBeCutIntoSections;

namespace LeetCode.Tests.T3001_T3500;

public class T3394_CheckIfGridCanBeCutIntoSections_Tests
{
    [Fact]
    public void Test02()
    {
        var taskClass = new T_CheckIfGridCanBeCutIntoSections();

        var n = 7;
        var rectangles = new int[][] { new int[] { 0, 0, 1, 1 }, new int[] { 2, 0, 3, 4 }, new int[] { 0, 2, 2, 3 }, new int[] { 3, 0, 4, 3 } };

        var result = taskClass.CheckValidCuts(n, rectangles);

        var expected = true;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_CheckIfGridCanBeCutIntoSections();

        var n = 4;
        var rectangles = new int[][] { new int[] { 0, 2, 2, 4 }, new int[] { 1, 0, 3, 2 }, new int[] { 2, 2, 3, 4 }, new int[] { 3, 0, 4, 2 }, new int[] { 3, 2, 4, 4 } };

        var result = taskClass.CheckValidCuts(n, rectangles);

        var expected = false;

        Assert.Equal(expected, result);
    }
}
