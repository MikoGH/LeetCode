using LeetCode.T1001_T1500.T1001_T1100.T1061_LexicographicallySmallestEquivalentString;

namespace LeetCode.Tests.T1001_T1500;

public class T1061_LexicographicallySmallestEquivalentString_Tests
{
    [Fact]
    public void Test01()
    {
        var taskClass = new T_LexicographicallySmallestEquivalentString();
        
        var s1 = "parker";
        var s2 = "morris";
        var baseStr = "parser";

        var result = taskClass.SmallestEquivalentString(s1, s2, baseStr);

        var expected = "makkek";

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test02()
    {
        var taskClass = new T_LexicographicallySmallestEquivalentString();

        var s1 = "hello";
        var s2 = "world";
        var baseStr = "hold";

        var result = taskClass.SmallestEquivalentString(s1, s2, baseStr);

        var expected = "hdld";

        Assert.Equal(expected, result);
    }
}
