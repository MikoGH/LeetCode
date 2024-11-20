using LeetCode.T3001_T3500.T3163_StringCompressionIII;

namespace LeetCode.Tests.T3001_T3500;

public class T3163_StringCompressionIII_Tests
{
    [Theory]
    [InlineData("aaab", "3a1b")]
    [InlineData("aaaaaaaaab", "9a1b")]
    [InlineData("aaaaaaaaaab", "9a1a1b")]
    [InlineData("a", "1a")]
    [InlineData("abbbbbbbbb", "1a9b")]
    [InlineData("aaaaaaaaabbbbbbbbb", "9a9b")]
    [InlineData("abbbbbbbbbb", "1a9b1b")]
    [InlineData("abbbbbbbbbc", "1a9b1c")]
    [InlineData("abbbbbbbbbbc", "1a9b1b1c")]
    public void Test1(string s, string expected)
    {
        var taskClass = new T_StringCompressionIII();
        var result = taskClass.CompressedString(s);
        Assert.Equal(expected, result);
    }
}
