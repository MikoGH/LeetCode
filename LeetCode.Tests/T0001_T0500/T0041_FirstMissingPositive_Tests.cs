using LeetCode.T0001_T0500.T0041_FirstMissingPositive;

namespace LeetCode.Tests.T0001_T0500;

public class T0041_FirstMissingPositive_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_FirstMissingPositive();

        var nums = new int[] { 1, 2, 0 };

        var result = taskClass.FirstMissingPositive(nums);

        var expected = 3;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_FirstMissingPositive();

        var nums = new int[] { 3, 4, -1, 1 };

        var result = taskClass.FirstMissingPositive(nums);

        var expected = 2;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_FirstMissingPositive();

        var nums = new int[] { 1 };

        var result = taskClass.FirstMissingPositive(nums);

        var expected = 2;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_FirstMissingPositive();

        var nums = new int[] { 100000, 3, 4000, 2, 15, 1, 99999 };

        var result = taskClass.FirstMissingPositive(nums);

        var expected = 4;

        Assert.Equal(expected, result);
    }
}
