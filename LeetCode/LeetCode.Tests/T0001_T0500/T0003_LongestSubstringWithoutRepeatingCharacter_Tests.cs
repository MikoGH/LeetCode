using LeetCode.T0001_T0500.T0003_LongestSubstringWithoutRepeatingCharacter;

namespace LeetCode.Tests.T0001_T0500;

public class T0003_LongestSubstringWithoutRepeatingCharacter_Tests
{
    [Theory]
    [InlineData("abcdag", 5)]
    [InlineData("zAZ123!@&*(~-} ", 15)]
    public void Test01(string s, int expected)
    {
        var taskClass = new T_LongestSubstringWithoutRepeatingCharacter();

        var result = taskClass.LengthOfLongestSubstring(s);

        Assert.Equal(expected, result);
    }
}
