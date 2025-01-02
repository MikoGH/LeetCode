using LeetCode.T0501_T1000.T0689_MaximumSumOf3NonOverlappingSubarrays;

namespace LeetCode.Tests.T0501_T1000;

public class T0689_MaximumSumOf3NonOverlappingSubarrays_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_MaximumSumOf3NonOverlappingSubarrays();

        var nums = new int[] { 1, 2, 1, 2, 6, 7, 5, 1 };
        int k = 2;

        var result = taskClass.MaxSumOfThreeSubarrays(nums, k);

        var expected = new int[] { 0, 3, 5 };

        Assert.Equal(expected, result);
    }
}
