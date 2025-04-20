using LeetCode.T2501_T3000.T2501_T2600.T2537_CountTheNumberOfGoodSubarrays;

namespace LeetCode.Tests.T2501_T3000;

public class T2537_CountTheNumberOfGoodSubarrays_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_CountTheNumberOfGoodSubarrays();

        var nums = new int[] { 1, 1, 1, 1, 1 };
        var k = 10;

        var result = taskClass.CountGood(nums, k);

        var expected = 1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_CountTheNumberOfGoodSubarrays();

        var nums = new int[] { 3, 1, 4, 3, 2, 2, 4 };
        var k = 2;

        var result = taskClass.CountGood(nums, k);

        var expected = 4;

        Assert.Equal(expected, result);
    }
}
