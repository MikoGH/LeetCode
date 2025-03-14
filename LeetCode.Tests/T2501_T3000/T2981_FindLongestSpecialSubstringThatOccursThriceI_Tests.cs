using LeetCode.T2501_T3000.T2901_T3000.T2981_FindLongestSpecialSubstringThatOccursThriceI;

namespace LeetCode.Tests.T2501_T3000;

public class T2981_FindLongestSpecialSubstringThatOccursThriceI_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_FindLongestSpecialSubstringThatOccursThriceI();

        var s = "aaaa";

        var result = taskClass.MaximumLength(s);

        var expected = 2;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_FindLongestSpecialSubstringThatOccursThriceI();

        var s = "abcdef";

        var result = taskClass.MaximumLength(s);

        var expected = -1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test03()
    {
        var taskClass = new T_FindLongestSpecialSubstringThatOccursThriceI();

        var s = "abbaca";

        var result = taskClass.MaximumLength(s);

        var expected = 1;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test04()
    {
        var taskClass = new T_FindLongestSpecialSubstringThatOccursThriceI();

        var s = "bbbabb";

        var result = taskClass.MaximumLength(s);

        var expected = 2;

        Assert.Equal(expected, result);
    }
}
