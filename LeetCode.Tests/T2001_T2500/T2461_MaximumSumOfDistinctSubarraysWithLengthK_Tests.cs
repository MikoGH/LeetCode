using LeetCode.T2001_T2500.T2461_MaximumSumOfDistinctSubarraysWithLengthK;

namespace LeetCode.Tests.T2001_T2500;

public class T2461_MaximumSumOfDistinctSubarraysWithLengthK_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MaximumSumOfDistinctSubarraysWithLengthK();

        var nums = new int[] { 1, 2, 3, 4 };
        var k = 2;

        var result = taskClass.MaximumSubarraySum(nums, k);

        var expected = 3 + 4;

        Assert.Equal(expected, result);
    }
}
