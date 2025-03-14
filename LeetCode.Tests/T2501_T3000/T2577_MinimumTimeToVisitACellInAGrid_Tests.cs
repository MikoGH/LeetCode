using LeetCode.T2501_T3000.T2501_T2600.T2577_MinimumTimeToVisitACellInAGrid;

namespace LeetCode.Tests.T2501_T3000;

public class T2577_MinimumTimeToVisitACellInAGrid_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MinimumTimeToVisitACellInAGrid();

        var nums = new int[3][] {
            new int[] { 0, 2, 4 },
            new int[] { 3, 2, 1 },
            new int[] { 1, 0, 4 }
        };

        var result = taskClass.MinimumTime(nums);

        var expected = -1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_MinimumTimeToVisitACellInAGrid();

        var nums = new int[3][] {
            new int[] { 0, 1, 3, 2 },
            new int[] { 5, 1, 2, 5 },
            new int[] { 4, 3, 8, 6 }
        };

        var result = taskClass.MinimumTime(nums);

        var expected = 7;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_MinimumTimeToVisitACellInAGrid();

        var nums = new int[2][] {
            new int[] { 0, 1, 2, 4 },
            new int[] { 10, 10, 10, 5 }
        };

        var result = taskClass.MinimumTime(nums);

        var expected = 6;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_MinimumTimeToVisitACellInAGrid();

        var nums = new int[2][] {
            new int[] { 0, 1, 2, 5 },
            new int[] { 10, 10, 10, 5 }
        };

        var result = taskClass.MinimumTime(nums);

        var expected = 6;

        Assert.Equal(expected, result);
    }
}
