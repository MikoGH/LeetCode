using LeetCode.T3001_T3500.T3011_FindIfArrayCanBeSorted;

namespace LeetCode.Tests.T3001_T3500;

public class T3011_FindIfArrayCanBeSorted_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_FindIfArrayCanBeSorted();

        var nums = new int[5] { 8, 4, 2, 30, 15 };

        var result = taskClass.CanSortArray(nums);

        Assert.True(result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_FindIfArrayCanBeSorted();

        var nums = new int[5] { 3, 16, 8, 4, 2 };

        var result = taskClass.CanSortArray(nums);

        Assert.False(result);
    }
}
