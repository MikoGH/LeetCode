using LeetCode.T3001_T3500.T3097_ShortestSubarrayWithORAtLeastKII;

namespace LeetCode.Tests.T3001_T3500;

public class T3097_ShortestSubarrayWithORAtLeastKII_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ShortestSubarrayWithORAtLeastKII();

        var nums = new int[] { 1, 2, 3 };

        var k = 2;

        var result = taskClass.MinimumSubarrayLength(nums, k);

        var expected = 1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_ShortestSubarrayWithORAtLeastKII();

        var nums = new int[] { 2, 1, 8 };

        var k = 10;

        var result = taskClass.MinimumSubarrayLength(nums, k);

        var expected = 3;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_ShortestSubarrayWithORAtLeastKII();

        var nums = new int[] { 1, 2 };

        var k = 0;

        var result = taskClass.MinimumSubarrayLength(nums, k);

        var expected = 1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_ShortestSubarrayWithORAtLeastKII();

        var nums = new int[] { 32, 1, 2, 81, 76, 58 };

        var k = 125;

        var result = taskClass.MinimumSubarrayLength(nums, k);

        var expected = 2;

        Assert.Equal(expected, result);
    }
}
