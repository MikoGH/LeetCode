using LeetCode.T1001_T1500.T1401_T1500.T1498_NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

namespace LeetCode.Tests.T1001_T1500;

public class T1498_NumberOfSubsequencesThatSatisfyTheGivenSumCondition_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_NumberOfSubsequencesThatSatisfyTheGivenSumCondition();

        var nums = new int[] { 3, 5, 6, 7 };
        var target = 9;

        var result = taskClass.NumSubseq(nums, target);

        var expected = 4;

        Assert.Equal(expected, result);
    }
}
