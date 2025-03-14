using LeetCode.T0501_T1000.T0801_T0900.T0862_ShortestSubarrayWithSumAtLeastK;

namespace LeetCode.Tests.T0501_T1000;

public class T0862_ShortestSubarrayWithSumAtLeastK_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ShortestSubarrayWithSumAtLeastK_3();

        var nums = new int[] { 2, -1, 2 };
        var k = 3;

        var result = taskClass.ShortestSubarray(nums, k);

        var expected = 3;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_ShortestSubarrayWithSumAtLeastK_3();

        var nums = new int[] { 77, 19, 35, 10, -14 };
        var k = 19;

        var result = taskClass.ShortestSubarray(nums, k);

        var expected = 1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_ShortestSubarrayWithSumAtLeastK_3();

        var nums = new int[] { -10000 };
        var k = 1000000000;

        var result = taskClass.ShortestSubarray(nums, k);

        var expected = -1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_ShortestSubarrayWithSumAtLeastK_3();

        var nums = new int[] { 17, 85, 93, -45, -21 };
        var k = 150;

        var result = taskClass.ShortestSubarray(nums, k);

        var expected = 2;

        Assert.Equal(expected, result);
    }
}
