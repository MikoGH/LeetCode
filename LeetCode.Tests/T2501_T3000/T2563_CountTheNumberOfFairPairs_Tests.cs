using LeetCode.T2501_T3000.T2501_T2600.T2563_CountTheNumberOfFairPairs;

namespace LeetCode.Tests.T2501_T3000;

public class T2563_CountTheNumberOfFairPairs_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_CountTheNumberOfFairPairs();

        var nums = new int[] { 0, 1, 7, 4, 4, 5 };
        var lower = 3;
        var upper = 6;

        var result = taskClass.CountFairPairs(nums, lower, upper);

        var expected = 6;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_CountTheNumberOfFairPairs();

        var nums = new int[] { 1, 7, 9, 2, 5 };
        var lower = 11;
        var upper = 11;

        var result = taskClass.CountFairPairs(nums, lower, upper);

        var expected = 1;

        Assert.Equal(expected, result);
    }
}
