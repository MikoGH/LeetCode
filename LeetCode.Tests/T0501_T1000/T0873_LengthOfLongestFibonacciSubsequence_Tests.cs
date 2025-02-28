using LeetCode.T0501_T1000.T0873_LengthOfLongestFibonacciSubsequence;

namespace LeetCode.Tests.T0501_T1000;

public class T0873_LengthOfLongestFibonacciSubsequence_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_LengthOfLongestFibonacciSubsequence();

        var arr = new int[] { 2, 3, 4, 7, 11 };

        var result = taskClass.LenLongestFibSubseq(arr);

        var expected = 4;

        Assert.Equal(expected, result);
    }
}
