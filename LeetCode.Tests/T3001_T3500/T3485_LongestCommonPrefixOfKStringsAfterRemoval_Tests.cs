using LeetCode.T3001_T3500.T3401_T3500.T3485_LongestCommonPrefixOfKStringsAfterRemoval;

namespace LeetCode.Tests.T3001_T3500;

public class T3485_LongestCommonPrefixOfKStringsAfterRemoval_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_LongestCommonPrefixOfKStringsAfterRemoval();

        var words = new string[] { "jump", "run", "run", "jump", "run" };

        var k = 2;

        var result = taskClass.LongestCommonPrefix(words, k);

        var expected = new int[] { 3, 4, 4, 3, 4 };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_LongestCommonPrefixOfKStringsAfterRemoval();

        var words = new string[] { "dog", "racer", "car" };

        var k = 2;

        var result = taskClass.LongestCommonPrefix(words, k);

        var expected = new int[] { 0, 0, 0 };

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_LongestCommonPrefixOfKStringsAfterRemoval();

        var words = new string[] { "e", "ecde", "ebbbd", "abc", "bcaab" };

        var k = 2;

        var result = taskClass.LongestCommonPrefix(words, k);

        var expected = new int[] { 1, 1, 1, 1, 1 };

        Assert.Equal(expected, result);
    }
}
