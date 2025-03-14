using LeetCode.T1501_T2000.T1601_T1700.T1639_NumberOfWaysToFormATargetStringGivenADictionary;

namespace LeetCode.Tests.T1501_T2000;

public class T1639_NumberOfWaysToFormATargetStringGivenADictionary_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_NumberOfWaysToFormATargetStringGivenADictionary();

        var words = new string[] { "acca", "bbbb", "caca" };
        var target = "aba";

        var result = taskClass.NumWays(words, target);

        var expected = 6;

        Assert.Equal(expected, result);
    }
}
