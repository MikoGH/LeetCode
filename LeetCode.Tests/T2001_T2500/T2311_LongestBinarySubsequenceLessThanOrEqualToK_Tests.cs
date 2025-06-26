using LeetCode.T2001_T2500.T2301_T2400.T2311_LongestBinarySubsequenceLessThanOrEqualToK;

namespace LeetCode.Tests.T2001_T2500;

public class T2311_LongestBinarySubsequenceLessThanOrEqualToK_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_LongestBinarySubsequenceLessThanOrEqualToK();

        var s = "00101001";
        var k = 1;

        var result = taskClass.LongestSubsequence(s, k);

        var expected = 6;

        Assert.Equal(expected, result);
    }
}
