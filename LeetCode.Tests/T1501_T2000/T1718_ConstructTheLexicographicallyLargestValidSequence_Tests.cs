using LeetCode.T1501_T2000.T1701_T1800.T1718_ConstructTheLexicographicallyLargestValidSequence;

namespace LeetCode.Tests.T1501_T2000;

public class T1718_ConstructTheLexicographicallyLargestValidSequence_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_ConstructTheLexicographicallyLargestValidSequence();

        var result = taskClass.ConstructDistancedSequence(5);

        var expected = new int[] { 5, 3, 1, 4, 3, 5, 2, 4, 2 };

        Assert.Equal(expected, result);
    }
}
