using LeetCode.T0501_T1000.T0701_T0800.T0773_SlidingPuzzle;

namespace LeetCode.Tests.T0501_T1000;

public class T0773_SlidingPuzzle_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_SlidingPuzzle();

        var nums = new int[2][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 0, 5 }
        };

        var result = taskClass.SlidingPuzzle(nums);

        var expected = 1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_SlidingPuzzle();

        var nums = new int[2][] {
            new int[] { 2, 4, 3 },
            new int[] { 1, 0, 5 }
        };

        var result = taskClass.SlidingPuzzle(nums);

        var expected = 5;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_SlidingPuzzle();

        var nums = new int[2][] {
            new int[] { 4, 0, 3 },
            new int[] { 2, 1, 5 }
        };

        var result = taskClass.SlidingPuzzle(nums);

        var expected = 6;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test05()
    {
        var taskClass = new T_SlidingPuzzle();

        var nums = new int[2][] {
            new int[] { 3, 2, 4 },
            new int[] { 1, 5, 0 }
        };

        var result = taskClass.SlidingPuzzle(nums);

        var expected = 14;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test06()
    {
        var taskClass = new T_SlidingPuzzle();

        var nums = new int[2][] {
            new int[] { 5, 3, 2 },
            new int[] { 0, 4, 1 }
        };

        var result = taskClass.SlidingPuzzle(nums);

        var expected = 18;

        Assert.Equal(expected, result);
    }
}
