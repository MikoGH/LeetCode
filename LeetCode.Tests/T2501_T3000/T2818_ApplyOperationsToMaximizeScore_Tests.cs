using LeetCode.T2501_T3000.T2801_T2900.T2818_ApplyOperationsToMaximizeScore;

namespace LeetCode.Tests.T2501_T3000;

public class T2818_ApplyOperationsToMaximizeScore_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ApplyOperationsToMaximizeScore_2();

        var nums = new int[] { 8, 3, 9, 3, 8 };
        var k = 2;

        var result = taskClass.MaximumScore(nums, k);

        var expected = 81;

        Assert.Equal(expected, result);
    }
}
